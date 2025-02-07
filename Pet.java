public class Pet {
    public String type;
    public String breed;
    public String name;
    public String ownerFirstName;
    public String ownerLastName;
    public String ownerEmail;
    public String ownerPhone;

    // constructor
    Pet(String type, String breed, String name, String ownerFirstName, String ownerLastName, String ownerEmail, String ownerPhone) {
        this.type = type;
        this.breed = breed;
        this.name = name;
        this.ownerFirstName = ownerFirstName;
        this.ownerLastName = ownerLastName;
        this.ownerEmail = ownerEmail;
        this.ownerPhone = ownerPhone;
    }

    // setters
    public void setType(String type) {
        this.type = type;
    }

    public void setBreed(String breed) {
        this.breed = breed;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setOwnerFirstName(String ownerFirstName) {
        this.ownerFirstName = ownerFirstName;
    }

    public void setOwnerEmail(String ownerEmail) {
        this.ownerEmail = ownerEmail;
    }

    public void setOwnerLastName(String ownerLastName) {
        this.ownerLastName = ownerLastName;
    }

    public void setOwnerPhone(String ownerPhone) {
        this.ownerPhone = ownerPhone;
    }

    // getters
    public String getType() {
        return type;
    }

    public String getBreed() {
        return breed;
    }

    public String getName() {
        return name;
    }

    public String getOwnerFirstName() {
        return ownerFirstName;
    }

    public String getOwnerLastName() {
        return ownerLastName;
    }

    public String getOwnerEmail() {
        return ownerEmail;
    }

    public String getOwnerPhone() {
        return ownerPhone;
    }
}
