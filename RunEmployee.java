
package Taskperformance;

import java.util.Scanner;
public class RunEmployee {
    
  
     public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        
        System.out.println("Enter Name: ");
        String name = s.nextLine();
        
        System.out.println("Press F for Full Time or P for Part Time: ");
        char employeeType = s.next().charAt(0);
       
        switch(employeeType){
              case 'P':
                    System.out.println("Enter rate per hour and no of hours worked seperated by space: ");
                    double rph = s.nextDouble();
                    int hworked = s.nextInt();
                    PartTimeEmployee p = new PartTimeEmployee();
                    p.setName(name);
                    p.setWage(rph, hworked);
                    System.out.println("Name: "+ p.getName());
                    System.out.printf("Wage:%.2f",p.getWage());
                    break;
                case 'F':
                    System.out.println("Enter Monthly Salary:  ");
                    double monSal = s.nextDouble();            
                    FullTimeEmployee f = new FullTimeEmployee();
                    f.setName(name);
                    f.setMonthlySalary(monSal);
                    System.out.println("Name: "+ f.getName());
                    System.out.printf("Monthly Salary:%.2f",f.getMonthlySalary());
                    break;      
               default: 
                System.out.print("Invalid Employee Type.");  
            }
    } 
}