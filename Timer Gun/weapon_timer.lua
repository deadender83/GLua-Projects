SWEP.PrintName = "timerWeapon"
SWEP.Author = "deadender83"
SWEP.Intructions = "Basic Gun"
SWEP.Category = "Custom Weapons"

SWEP.Spawnable = true
SWEP.AdminOnly = false

SWEP.Primary.ClipSize = 12
SWEP.Primary.DefaultClip = 12
SWEP.Primary.Automatic = false
SWEP.Primary.Ammo = "Pistol"

SWEP.Secondary.Ammo = "Pistol"

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

function SWEP:Initialize()

    self:SetHoldType("pistol")

end

function SWEP:PrimaryAttack()
    if SERVER then
        local ply = self:GetOwner()
        if not IsValid(ply) then return end

        local spawnPos = ply:GetPos() + ply:GetForward() * 50 + Vector(0, 0, 10)

        local ent = ents.Create("projectile_entity")
        if not IsValid(ent) then
            return
        end
        ent:SetPos(spawnPos)
        ent:SetAngles(ply:EyeAngles())
        ent:Spawn()
        ent:Activate()
    end
end 


function SWEP.SecondaryAttack()
    
end
