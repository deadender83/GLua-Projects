SWEP.PrintName = "BowBomb"
SWEP.Author = "deadender83"
SWEP.Instructions = "Basic Bow"

SWEP.Spawnable = true
SWEP.AdminOnly = false

SWEP.Primary.ClipSize = 1
SWEP.Primary.DefaultClip = 1
SWEP.Primary.Automatic = false
SWEP.Primary.Ammo = "m9k_davy_crockett"

SWEP.Secondary.Ammo = "m9k_davy_crockett"

SWEP.Weight = 5
SWEP.AutoSwitchTo = false
SWEP.AutoSwitchFrom = false

SWEP.Slot = 1
SWEP.SlotPos = 2
SWEP.DrawAmmo = true
SWEP.DrawCrosshair = true

SWEP.ViewModel = "models/weapons/c_crossbow.mdl"
SWEP.WorldModel = "models/weapons/c_crossbow.mdl"

SWEP.UseHands = true

SWEP.ShootSound = Sound("weapons/mortar/mortar_explode1.wav")

function SWEP:PrimaryAttack()
    if not self:CanPrimaryAttack() then return end
    self:SetNextPrimaryFire(CurTime() + 2)

    if SERVER then
        local owner = self:GetOwner()
        if not IsValid(owner) then return end

        local nuke = ents.Create("m9k_nuclear_warhead") -- Spawn the correct entity
        if not IsValid(nuke) then return end

        local spawnPos = owner:GetShootPos() + (owner:GetAimVector() * 20)
        nuke:SetPos(spawnPos)
        nuke:SetAngles(owner:EyeAngles()) 
        nuke:SetOwner(owner)
        nuke:Spawn()
        nuke:Activate()

        local phys = nuke:GetPhysicsObject()
        if IsValid(phys) then
            phys:SetVelocity(owner:GetAimVector() * 1000) -- Launch the nuke
        end

        -- Force detonation after 3 seconds
        timer.Simple(3, function()
            if IsValid(nuke) then
                nuke:Fire("Explode", "", 0) -- Trigger explosion
            end
        end)
    end

    self:EmitSound("weapons/rpg/rocketfire1.wav") 
    self:TakePrimaryAmmo(1)
end


    self:EmitSound("weapons/rpg/rocketfire1.wav") 
    self:TakePrimaryAmmo(1)

function SWEP:SecondaryAttack()
end
