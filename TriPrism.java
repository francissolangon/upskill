/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.triprism;

import java.util.Scanner;

class TriPrism<T> {
    private T length;
    private T base;
    private T height;
    
    void setLength(T length) {
        this.length = length;
    }
    
    T getLength() {
        return length;
    }
    
    void setBase(T base) {
        this.base = base;
    }
    T getBase() {
        return base;
    }
    void setHeight(T height) {
        this.height = height;
    }
    T getHeight() {
        return height;
    }
}
public class TriPrismDemo {
    public static void main(String[] args) {
        Scanner input = new Scanner (System.in);
        TriPrism<Integer> tp1 = new TriPrism<>();
        TriPrism<Double> tp2 = new TriPrism<>();
        double volume;
        System.out.println("Triangular Prism 1 \n");
        System.out.println("Length");
        tp1.setLength(input.nextInt());
        System.out.println("Base");
        tp1.setBase(input.nextInt());
        System.out.println("Height");
        tp1.setHeight(input.nextInt());
        
        volume = tp1.getLength() * (0.5 * tp1.getBase() * tp1.getHeight());
        System.out.println("The volume of the Prism is:" + volume);
        System.out.println("\nTriangular Prism 2\n");
        
        System.out.println("Length");
        tp2.setLength(input.nextDouble());
        System.out.println("Base");
        tp2.setBase(input.nextDouble());
        System.out.println("Height");
        tp2.setHeight(input.nextDouble());
        
        volume = tp2.getLength() * (0.5 * tp2.getBase() * tp2.getHeight());
        System.out.println("The volume of the Prism is:" + volume);
        
    }
}