import java.io.File;
import java.io.FileNotFoundException;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        File file = new File("resources/pets.csv");

        try
        {
            Scanner scanner = new Scanner(file);
            HashMap<String, LinkedList<Pet>> petMap = new HashMap<>();

            while(scanner.hasNextLine())
            {
                String line = scanner.nextLine();
                String[] petArray = line.split(",");

                String petType = petArray[0];
                String petBreed = petArray[1];
                String petName = petArray[2];
                String ownerFirstName = petArray[3];
                String ownerLastName = petArray[4];
                String ownerEmail = petArray[5];
                String ownerPhoneNumber = petArray[6];


                Pet pet = new Pet(petType, petBreed, petName, ownerFirstName, ownerLastName, ownerEmail, ownerPhoneNumber);

                if (petMap.containsKey(petType)) {
                    petMap.get(petType).add(pet);
                } else {
                    LinkedList<Pet> petList = new LinkedList<>();
                    petList.add(pet);
                    petMap.put(petType, petList);
                }

            }

            for (String petType : petMap.keySet()) {
                System.out.println(petType);
                for (Pet pet : petMap.get(petType)) {
                    System.out.println("-".repeat(10) + " Pet Name: " + pet.getName() +
                            ", Breed: " + pet.getBreed() +
                            ", Owner: " + pet.getOwnerFirstName() + " " + pet.getOwnerLastName() +
                            ", Email: " + pet.getOwnerEmail() +
                            ", Phone: " + pet.getOwnerPhone());
                }
            }

            // Step 6.1: Output the count of each type of pet
            System.out.println("Pet Type Count:");
            for (String petType : petMap.keySet()) {
                System.out.println(petType + ": " + petMap.get(petType).size());
            }
            System.out.println(); 

            // Step 6.2: List the pet names for all Snakes
            System.out.println("Snake Names:");
            if (petMap.containsKey("Snake")) {
                for (Pet pet : petMap.get("Snake")) {
                    System.out.println("Snake: " + pet.getName());
                }
            }
            System.out.println();

            // Step 6.3: List the owner’s last name for all Rabbits
            System.out.println("Rabbit Owner Last Names:");
            if (petMap.containsKey("Rabbit")) {
                for (Pet pet : petMap.get("Rabbit")) {
                    System.out.println("Owner Last Name: " + pet.getOwnerLastName());
                }
            }

            scanner.close();

        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        }
    }
}
