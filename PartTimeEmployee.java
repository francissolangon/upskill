
package Taskperformance;

public class PartTimeEmployee extends Employee{
    
    private double ratePerHour;
    private double wage;
    private int hoursWorked;
    
    void setWage(double ratePerHour, int hoursWorked){
     this.ratePerHour = ratePerHour;
     this.hoursWorked = hoursWorked;
    }
    
    double getWage(){
     return wage = ratePerHour * hoursWorked;
    }
    
}
