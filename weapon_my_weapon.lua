SWEP.PrintName = "SixGauge"
SWEP.Author = "deadender83"
SWEP.Intructions = "Basic Gun"

SWEP.Spawnable = true
SWEP.AdminOnly = false

SWEP.Primary.ClipSize = 12
SWEP.Primary.DefaultClip = 12
SWEP.Primary.Automatic = false
SWEP.Primary.Ammo = "RPG_Round"

SWEP.Secondary.Ammo = "RPG_Round"

SWEP.Weight = 5
SWEP.AutoSwitchTo = false
SWEP.AutoSwitchFrom = false

SWEP.Slot = 1
SWEP.SlotPos = 2
SWEP.DrawAmmo = true
SWEP.DrawCrosshair = true

SWEP.ViewModel = "models/weapons/c_357.mdl"
SWEP.WorldModel = "models/weapons/w_357.mdl"

SWEP.UseHands = true

SWEP.ShootSound = Sound("weapons/shotgun/shotgun_dbl_fire.wav")

function SWEP:PrimaryAttack()
    if not self:CanPrimaryAttack() then return end

    self:SetNextPrimaryFire(CurTime() + 0.1)  

    if SERVER then  
        local owner = self:GetOwner()
        if not IsValid(owner) then return end

        local rocket = ents.Create("rpg_missile")
        if not IsValid(rocket) then return end

        local numRockets = 3  
        local spreadAngle = 10  

        local spawnPos = owner:GetShootPos() + (owner:GetAimVector() * 20)  
        rocket:SetPos(spawnPos)
        rocket:SetAngles(owner:EyeAngles()) 
        rocket:SetOwner(owner)

        rocket:Spawn()
        rocket:Activate()

        local phys = rocket:GetPhysicsObject()
        if IsValid(phys) then
            phys:SetVelocity(owner:GetAimVector() * 1500)  
        end
    end

    self:EmitSound("weapons/rpg/rocketfire1.wav")  
    self:TakePrimaryAmmo(1)  
end



function SWEP.SecondaryAttack()
    
end