
package javaapplication4;

import java.util.Arrays;
import java.util.Scanner;
public class JavaApplication4 {
    
    /*Submitted By:
    Solangon, Francis Emmanuel A.
    BSCS 101
    */
    
public static void main(String[] args) {
   
    // Initialize the bus layout
        char[][] busSeats = new char[10][4];
        
        // fill the array with *
        for (char[] row : busSeats) {
            Arrays.fill(row, '*');
        }

        // Scanner for user input
        Scanner input = new Scanner(System.in);

        // Seat reservation loop
        while (true) {
            // Display the current bus layout
            System.out.println("Bus Seat Reservation:");
            System.out.println("\tCol 1 \tCol 2 \tCol 3 \tCol 4");
            
            for (int i = 0; i < busSeats.length; i++) {
                System.out.print("Row " + (i + 1) + "\t|");
                for (int j = 0; j < busSeats[i].length; j++) {
                    System.out.print(busSeats[i][j] + "\t");
                }
                System.out.println();
            }
    
            // Ask the user for input
            System.out.print("Enter row and column number to reserve separated by space (Enter a negative number to exit): ");
            int rowNumber = input.nextInt();
            
            // Check if the user wants to exit
            if (rowNumber < 0) {
                System.out.println("Program exit!");
                break;
            }  
            int columnNumber = input.nextInt();

            // seat reservation
            busSeats[rowNumber - 1][columnNumber - 1] = 'X';       
        }
    }
}