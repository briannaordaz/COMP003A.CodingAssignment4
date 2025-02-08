//Author: Brianna Ordaz
// Course: COMP-003A
// Faculty: Jonathan Cruz
//Purpose: Inventory management application with a minimum of 10 elements in the collection.
namespace COMP003A.CodingAssignment4;

internal class Program
{
    static void Main(string[] args)
    {


         
        
        int[] objectAmount = new int[10];
        string[] objectName = new string [10];
        int count = 0;

        
        

        

        while (true)
        {
            int userChoice = 0;

           
            
            Console.WriteLine("Inventory Management System Menu: ");
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. Update Product Quantity");
            Console.WriteLine("3. View Inventory Summary");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select an option (1-4): ");
            userChoice = int.Parse(Console.ReadLine());
            
             if (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Invalid Number, Please pick a number 1-4: ");
            }  

            if (userChoice == 1)
            {
                Console.WriteLine("Add a Product:");
                string pdtName = Console.ReadLine();
                
                Console.WriteLine("Enter Product Quantity: ");
                int pdtAmount = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Product added successfully! ");



                if (count < objectName.Length)
                {
                    objectName[count] = pdtName;
                    objectAmount[count] = pdtAmount;
                    count++;
                }
                else
                {
                    Console.WriteLine("Full Inventory");
                }
                
                /* if (count < productNames.Length)
                   {
                       productNames[count] = "Apples";
                       productQuantities[count] = 50;
                       count++;
                   }
                   else
                   {
                       Console.WriteLine("Inventory is full!");
                   } */
                
                
            }
            
            if (userChoice == 2)
            {
                Console.WriteLine("Name of Object you wish to Update: ");
                string pdtName = Console.ReadLine();
                
                Console.WriteLine("Enter the Amount of the Object you wish to update it to: ");
                int pdtAmount = int.Parse(Console.ReadLine());
                
               int index = Array.IndexOf(objectName, pdtName);
               if (index != -1)
               {
                   
                   objectAmount[index] = pdtAmount;
               }
               else
               {
                   Console.WriteLine("Object is not available");
               }
               

                /*
                 int index = Array.IndexOf(productNames, "Apples");
                   if (index != -1)
                   {
                       productQuantities[index] = 100;
                   }
                   else
                   {
                       Console.WriteLine("Product not found.");
                   }
                 */
            }

            if (userChoice == 3)
            {
                Console.WriteLine("Inventory Summary: ");
                
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(objectName[i] + ": $" + objectAmount[i] + ".00");
                }
                
                Console.WriteLine("Total products: " + count);
                




            }

            if (userChoice == 4)
            {
                Console.WriteLine("GoodBye!");
                break;
                
            }

        } 

    }
}


/*2. Application Requirements
   
         1. Start with an Empty Collection - Use arrays or lists or both
         Hint: Use new string[10] and new int[10] for arrays or new List<string>() and new List<int>() for lists.
         The inventory should initially be empty, ready to store up to 10 products (if using arrays), or allow unlimited additions (if using lists).
  
         2. Prompt User Input
         Optional: At the program's start, allow users to select whether to use arrays or lists for inventory storage.
          /  Hint: Use Console.WriteLine to display options and int.Parse(Console.ReadLine()) to capture user input.
          * Display a menu with the following options:
            1. Add a Product
            2. Update Product Quantity
            3. View Inventory Summary
            4. Exit
   
   
    3. Perform Operations Based on the Menu Selection
   
      * Add a Product:
          * Prompt the user for:
              * Product name (e.g., "Apples").
              * Product quantity (e.g., 50).
 
          * Add the product name and quantity to the inventory.
          / Hint for Arrays: Use an integer count variable to track how many items have been added. 
             * Ensure the count does not exceed the array's size.
          / Hint for Lists: Simply use the .Add() method to dynamically add new elements.
             * Ensure the array can hold up to 10 products. If the array is full, notify the user.
 
      * Update Product Quantity:
           * Prompt the user to enter the product name.
           * If the product exists, allow the user to update its quantity.
           / Hint for Arrays: Use Array.IndexOf() to find the index of the product name.
           / Hint for Lists: Use .IndexOf() to find the index of the product name.
           * Display a success message, or notify the user if the product does not exist.
 
      * View Inventory Summary:
           * Display all product names and their quantities.
           * Show:
              # Total number of products.
              # Total inventory quantity.
              # Average product quantity.
           / Hint: Use a for loop to iterate through the array or list to calculate totals and averages.
           
      * Exit:
           * Terminate the program with a friendly goodbye message.
                          
                      
    
    4. Validation
                                 
      * Handle invalid inputs using try-catch blocks.
         / Hint: Wrap user input in try-catch to catch exceptions from invalid conversions (e.g., int.Parse).
      * Provide meaningful error messages, such as:
         * "Invalid input. Please enter a valid number."
         * "Product not found. Please try again."
         * "Inventory is full. Cannot add more products."
  
  3. Example Input/Output
  
      Sample Run 1 (Using Arrays):
                  
                      
        Welcome to the Inventory Management System!
        Choose data storage type:
        1. Arrays
        2. Lists
        Enter your choice: 1
                        
        Inventory Management System Menu:
        1. Add a Product
        2. Update Product Quantity
        3. View Inventory Summary
        4. Exit
        Enter your choice: 1
                        
        Enter product name: Apples
        Enter product quantity: 50
        Product added successfully!
                      
        Inventory Management System Menu:
        1. Add a Product
        2. Update Product Quantity
        3. View Inventory Summary
        4. Exit
        Enter your choice: 3
                               
        Inventory Summary:
         - Apples: 50
        Total Products: 1
        Total Quantity: 50
        Average Quantity: 50.00
                       
    Sample Run 2 (Using Lists):
                                  
        Welcome to the Inventory Management System!
        Choose data storage type:
        1. Arrays
        2. Lists
        Enter your choice: 2
   
        Inventory Management System Menu:
        1. Add a Product
        2. Update Product Quantity
        3. View Inventory Summary
        4. Exit
        Enter your choice: 1
   
        Enter product name: Oranges
        Enter product quantity: 30
        Product added successfully!
   
        Inventory Management System Menu:
        1. Add a Product
        2. Update Product Quantity
        3. View Inventory Summary
        4. Exit
        Enter your choice: 3
   
        Inventory Summary:
        - Oranges: 30
        Total Products: 1
        Total Quantity: 30
        Average Quantity: 30.00
        
        
        
  4. Implementation Hints
     1. Empty Collections
       * Arrays:
            string[] productNames = new string[10];
            int[] productQuantities = new int[10];
            int count = 0; // Keeps track of how many products are in the array
       
       * Lists:
            List<string> productNames = new List<string>();
            List<int> productQuantities = new List<int>();
            
     2. Adding a Product
       * Arrays:
            if (count < productNames.Length)
            {
                productNames[count] = "Apples";
                productQuantities[count] = 50;
                count++;
            }
            else
            {
                Console.WriteLine("Inventory is full!");
            }
       * Lists:
            productNames.Add("Apples");
            productQuantities.Add(50);
            
     3. Updating a Product
       * Arrays:
            int index = Array.IndexOf(productNames, "Apples");
            if (index != -1)
            {
                productQuantities[index] = 100;
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
       * Lists:
            int index = productNames.IndexOf("Apples");
            if (index != -1)
            {
                productQuantities[index] = 100;
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            
*/