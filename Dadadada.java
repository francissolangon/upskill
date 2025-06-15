/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.dadadada;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 *
 * @author Francis
 */
public class Dadadada {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.print("Enter the first word: ");
        String word1 = s.nextLine();

        System.out.print("Enter the second word: ");
        String word2 = s.nextLine();

        String sub = word1.substring(word1.length() - 2);

        Pattern pattern = Pattern.compile("[a-zA-Z]{1,2}" + sub + " ");

        Matcher matcher = pattern.matcher(word2);

        if (matcher.matches()) {
            System.out.println(word2 + " rhymes with " + word1);
        } else {
            System.out.println("I'm not sure! Sorry!");
        }

  }
}
