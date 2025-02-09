SWEP.Category = "Roman Sword"
SWEP.Author = "Deadender83"
SWEP.Contact = ""
SWEP.Purpose = ""
SWEP.Instructions = ("Left click to slash and Hold right mouse to put up guard.")
SWEP.PrintName = "Roman Sword"  

SWEP.Slot = 0                
SWEP.SlotPos = 21        
SWEP.DrawAmmo = true        
SWEP.DrawWeaponInfoBox = true        
SWEP.BounceWeaponIcon = false    
SWEP.DrawCrosshair = false        
SWEP.Weight = 30            
SWEP.AutoSwitchTo = true        
SWEP.AutoSwitchFrom = true        
SWEP.HoldType = "melee"   

--models
SWEP.ViewModelFOV = 70
SWEP.ViewModelFlip = false
SWEP.ViewModel = "models/weapons/v_romansword.mdl"    
SWEP.WorldModel = "models/weapons/w_roman_sword_1_reference.mdl"    
SWEP.ShowWorldModel = true

SWEP.Base = "weapon_base"
SWEP.Spawnable = true
SWEP.AdminSpawnable = true
SWEP.FiresUnderwater = false

SWEP.Primary.RPM = 300            
SWEP.Primary.ClipSize = 30        
SWEP.Primary.DefaultClip = 60        
SWEP.Primary.KickUp    = 0.4        
SWEP.Primary.KickDown = 0.3        
SWEP.Primary.KickHorizontal = 0.3        
SWEP.Primary.Automatic = false        
SWEP.Primary.Ammo = ""            

SWEP.Secondary.IronFOV = 0        

SWEP.data = {}  

SWEP.data.ironsights = 1
SWEP.Primary.Damage    = 30    
SWEP.Primary.Spread    = .02    
SWEP.Primary.IronAccuracy = .01 

SWEP.IronSightsPos = Vector(-1.267, -15.895, -7.205)
SWEP.IronSightsAng = Vector(70, -27.234, 70)
SWEP.SightsPos = Vector(-1.267, -15.895, -7.205)
SWEP.SightsAng = Vector(70, -27.234, 70)
SWEP.RunSightsPos = Vector(0, 0, 0)
SWEP.RunSightsAng = Vector(-25.577, 0, 0)
SWEP.Slash = 1

-- sounds
SWEP.Primary.Sound = Sound("weapons/blades/woosh.mp3") 
SWEP.KnifeShink = Sound("weapons/blades/hitwall.mp3")
SWEP.KnifeSlash = Sound("weapons/blades/slash.mp3")
SWEP.KnifeStab = Sound("weapons/blades/nastystab.mp3")
SWEP.SwordChop = Sound("weapons/blades/swordchop.mp3")
SWEP.SwordClash = Sound("weapons/blades/clash.mp3")

function SWEP:PrimaryAttack()
    if not self:GetOwner():IsPlayer() then return end

    if self:GetOwner():KeyDown(IN_ATTACK2) then
        return
    end

    local pos = self:GetOwner():GetShootPos()
    local ang = self:GetOwner():GetAimVector()
    local vm = self:GetOwner():GetViewModel()
    local damagedice = math.Rand(.85,1.25)
    local pain = self.Primary.Damage * damagedice
    if self:CanPrimaryAttack() and self:GetOwner():IsPlayer() then
        self.Weapon:SendWeaponAnim(ACT_VM_IDLE)
        if not self:GetOwner():KeyDown(IN_SPEED) and not self:GetOwner():KeyDown(IN_RELOAD) and not self:GetOwner():KeyDown(IN_ATTACK2) then
            if self.Slash == 1 then
                vm:SetSequence(vm:LookupSequence("midslash1"))
                self.Slash = 2
            else
                vm:SetSequence(vm:LookupSequence("midslash2"))
                self.Slash = 1
            end 
            self.Weapon:EmitSound(self.Primary.Sound)
            if SERVER and IsValid(self:GetOwner()) and self:GetOwner():Alive() then
                local slash = {}
                slash.start = pos
                slash.endpos = pos + (ang * 52)
                slash.filter = self:GetOwner()
                slash.mins = Vector(-15, -5, 0)
                slash.maxs = Vector(15, 5, 5)
                local slashtrace = util.TraceHull(slash)
                if slashtrace.Hit then
                    local targ = slashtrace.Entity
                    if targ:IsPlayer() or targ:IsNPC() then
                        self.Weapon:EmitSound(self.SwordChop)
                        local paininfo = DamageInfo()
                        paininfo:SetDamage(pain)
                        paininfo:SetDamageType(DMG_SLASH)
                        paininfo:SetAttacker(self:GetOwner())
                        paininfo:SetInflictor(self.Weapon)
                        paininfo:SetDamageForce(slashtrace.Normal * 35000)
                        targ:TakeDamageInfo(paininfo)
                    else
                        self.Weapon:EmitSound(self.KnifeShink)
                        local look = self:GetOwner():GetEyeTrace()
                        util.Decal("ManhackCut", look.HitPos + look.HitNormal, look.HitPos - look.HitNormal)
                    end
                end
            end
            self:GetOwner():SetAnimation(PLAYER_ATTACK1)
            self.Weapon:SetNextPrimaryFire(CurTime() + 1 / (self.Primary.RPM / 60))
        end
    end
end

hook.Add("PlayerShouldTakeDamage", "RomanSwordGuardUp", function(ply, attacker)
    local weapon = ply:GetActiveWeapon()
    if not weapon or not weapon:GetClass() == "roman_sword" then return end
    if not ply:KeyDown(IN_ATTACK2) then return end
    return false
end)

function SWEP:SecondaryAttack()
    if self:GetOwner():KeyDown(IN_ATTACK2) then
        self.DrawCrosshair = false
        self:SendWeaponAnim(ACT_VM_IDLE)
    else
        self.DrawCrosshair = true
    end
    self:SetNextSecondaryFire(CurTime() + 0.3)
end

function SWEP:Timer()
    timer.Create("healthTimer", 5, 1, function()
        local owner = self:GetOwner()
        if IsValid(owner) then
            owner:SetHealth(owner:Health() + 5) 
        end
    end)
end

function SWEP:StartHealing()
    if SERVER then
        timer.Create("HealthRegen_" .. self:EntIndex(), 5, 0, function()
            local owner = self:GetOwner()
            if IsValid(owner) then
                local newHealth = math.min(owner:Health() + 5, owner:GetMaxHealth()) 
                owner:SetHealth(newHealth)
            end
        end)
    end
end

function SWEP:StopHealing()
    if SERVER then
        timer.Remove("Health Regen" .. self:EntIndex())
    end
end

function SWEP:Deploy()
    self:StartHealing()
    return true
end

function SWEP:Holster()
    self:StopHealing() 
    return true
end