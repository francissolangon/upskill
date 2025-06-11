
package javaapplication5;

import java.util.Scanner;

public class JavaApplication5 {
    
    /*Submitted By:
    Solangon, Francis Emmanuel A.
    BSCS 101
    */
    
public static void main(String[] args) {
   
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter mass in kilograms: ");
        double mass = scanner.nextDouble();

        System.out.print("Enter velocity in meters per second: ");
        double velocity = scanner.nextDouble();

        double kineticEnergy = calculateKineticEnergy(mass, velocity);

        System.out.printf("The object's kinetic energy is: %.2f" + " J." , kineticEnergy );
    }

    private static double calculateKineticEnergy(double mass, double velocity) {
        
        return 0.5 * mass * Math.pow(velocity, 2);
    }
}
         
 
    
    

