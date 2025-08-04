package com.gamblerapi.dao.GamblerDAO;

import com.gamblerapi.model.Gambler;

import java.util.ArrayList;
import java.util.List;

public class GamblerMemoryDao {
    /***********************************************************************
     *  GamblerDAO Starter Code
     *  
     *  DAO - Data Access Object - Used to Manipulate data in a data source
     **************************************************************************/

    // Data Source
    private List<Gambler> gamblers;   // Reference to data source

    // Constructor - Initializes the data source
    public GamblerMemoryDao()
    {
        this.gamblers = new ArrayList<Gambler>(); // Instantiate the data source object

        // Initialize the data source - using constructor and hardcoded data
        gamblers.add(new Gambler(12 , "T Judson Smith" , "Los Angeles, CA", 1398.65,    "05/01/1972"));
        gamblers.add(new Gambler(49 , "Dana Imori"     , ""               , 7580.50,    "08/08/1938"));
        gamblers.add(new Gambler(201, "S.Q. Elle"      , "Relational, DA" , 1000000.01, "05/23/1995"));
        gamblers.add(new Gambler(54 , "Neil Bransfield", "Seattle, WA"    , 5000.00,    "03/11/1959"));
        gamblers.add(new Gambler(382, "Stickman Nelson", "Cumberland, MD" , 12983.75,   "10/21/1955"));
        gamblers.add(new Gambler(572, "Al Mostbroke"   , "Clayton MO"     , 4505.55,    "01/18/1975"));
    }

    // Method to return all entries in the data source
    public List<Gambler> getGamblers()
    {
        return gamblers;
    } // End of getGamblers() method

    // Method to return a gambler by ID
    // The first thing you need is a method signature for the method
    // A method signature:
    // access return-type method-name(parameters)
    public Gambler getGamblerById(int id)
    {
        // Loop through the data source to find the gambler with the given ID
        // Use a for-each loop to iterate through the list of gamblers
        // for(type-and-name-for-element : data-structure) { ... }
           for(Gambler aGambler : gamblers) {
            // Check if the current gambler's ID matches the given ID
            if (aGambler.getId() == id) {
                return aGambler; // Return the gambler if found
            }
        }
        // Return null if no gambler with the given ID is found
        return null;
    } // End of getGamblerById() method

    // Method to retrieve a gambler by name
    public Gambler getGamblerByName(String name) {
        // Loop through the data source to find the gambler with the given name
        for (Gambler aGambler : gamblers) {
            // Check if the current gambler's name matches the given name
            // Use equalsIgnoreCase to compare names without case sensitivity
            // Note use of getter for current gambler's name
            if (aGambler.getName().equalsIgnoreCase(name)) {
                return aGambler; // Return the gambler if found
            }
        }
        // Return null if no gambler with the given name is found
        return null;
    } // End of getGamblerByName() method


    // Add a Gambler to data source
    //
    // 1. Need to have a Gambler to add to data source - a parameter passed to the method
    //          Note: DAO's work with objects NOT individual fields
    // 2. Add a Gambler to data source
    // 3. If a Gambler is successfully added to the data source, return the object added
    // 4. If a Gambler is NOT successfully added to the data source, return null

    public Gambler addGambler(Gambler aGambler){
        // Receive the Gambler to be added as a parameter
        // Use exception handling to determine if the object was added correctly
        // If no exception happens it works
        // If an exception does happen it didn't work


        try { // Use exception handling for statements in the block
            gamblers.add(aGambler);
        }
        catch (Exception anExceptionBlock) { // If an Exception happens in the try block, do this
            return null; // We return a null object if the adding didn't work
        }

        return aGambler;
    }

    // if you do not care if it works or not: return gamblers.add(aGambler)
    // if you want to use the boolean that is returned by the adding instead of Exception Handling
    //
    //      if(gamblers.addGambler) {   // if the .add returned true.....
    //              return aGambler;    // return the object that was added
    //          {
    //          else {                  // if the .add returned false...
    //              return null;        // return null
    //          }

    public Gambler updateGambler(Gambler updatedGambler) {
        //  1. Since our data source (ArrayList) does not have a method to replace an existing element
        //  2. Remove the existing object
        //      a. Find the existing object - use a unique value (primary key)
        //      b. Remove
        //  3. Add the new object

        // Find the existing Gambler by ud by using the existing method to do that
        Gambler existingGambler = getGamblerById(updatedGambler.getId());

        // Remove the existing Gambler
        gamblers.remove(existingGambler);

        // Add the updated gambler
        gamblers.add(updatedGambler);

        return updatedGambler;
    }

    public void zapAGambler(int gamblerId){
        Gambler existingGambler = getGamblerById(gamblerId);
        gamblers.remove(existingGambler);
    }



}  // end of GamblerMemoryDao class
