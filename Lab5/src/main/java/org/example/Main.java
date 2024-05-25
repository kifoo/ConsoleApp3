package org.example;

import java.util.List;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter the number of items:");
        int n = Integer.parseInt(scanner.nextLine());

        System.out.println("Enter the capacity:");
        int capacity = Integer.parseInt(scanner.nextLine());

        System.out.println("Enter the seed:");
        int seed = Integer.parseInt(scanner.nextLine());

        KnapsackProblem problem = new KnapsackProblem(n, seed);
        System.out.println("Problem:");
        System.out.println(problem);

        System.out.println("Solution:");
        Result result = problem.solve(capacity);
        System.out.println(result);
    }
}