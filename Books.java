/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.books;

import java.util.*;

public class Books {
    
         public static void main(String[] args) {
            Scanner s = new Scanner(System.in);

            Queue<String> movies = new LinkedList<>();
            Queue<String> snacks = new LinkedList<>();

            for (int i = 1; i <= 3; i++) {
                System.out.print("Enter movie " + i + " of 3: ");
                movies.offer(s.nextLine());
                }              

            for (int i = 1; i <= 3; i++) {
                System.out.print("Enter snack " + i + " of 3: ");
                snacks.offer(s.nextLine());
                }

            System.out.println("Movies to watch are: " + movies);
            System.out.println("Snacks to eat are: " + snacks);
            
            System.out.println("Press S each time you finish a snack.");
      
            
                while(!snacks.isEmpty()){
                    
                String eat = s.nextLine();
                
                if (snacks.isEmpty()){
                    System.out.println("No more snacks");
                     }
                 
                else if(eat.equalsIgnoreCase("S")){
                    snacks.poll();
                    System.out.println("deque("+snacks+")");
                 }
                   
                 }
            }
         
}