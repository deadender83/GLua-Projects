AddCSLuaFile()

ENT.Type = "anim" 
ENT.Base = "base_gmodentity" 
ENT.PrintName = "Timer Entity" 
ENT.Author = "deadender83" 
ENT.Category = "Test entities" 
ENT.Contact = "STEAM_0:1:12345678"
ENT.Purpose = "To test the creation of entities." 
ENT.Spawnable = true 

function ENT:Initialize()
	if SERVER then
	    self:SetModel( "models/hunter/blocks/cube025x025x025.mdl" ) 
	    self:PhysicsInit( SOLID_VPHYSICS ) 
	    self:SetMoveType( MOVETYPE_VPHYSICS ) 
	    self:SetSolid( SOLID_VPHYSICS ) 
	    local phys = self:GetPhysicsObject() 
	    if phys:IsValid() then 
	        phys:Wake() 
	    end
	end
end

function ENT:Think()
    self:NextThink(CurTime())
    return true
end

function ENT:OnTakeDamage(dmginfo)
    -- Handle damage here
    self:Remove()
end

function ENT:StartCountdown()
    for i = 10, 1, -1 do
        print(i)
    end
end

function ENT:Use(activator, caller)
    self:StartCountdown()
    print("I did the thing!")
end


if not CLIENT then return end

function ENT:Draw()
    self:DrawModel() 
end