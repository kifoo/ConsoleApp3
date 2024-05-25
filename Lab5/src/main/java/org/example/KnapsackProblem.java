package org.example;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class KnapsackProblem {
    private int n;
    private List<Item> items;

    public KnapsackProblem(int n, int seed) {
        this(n, seed, 2, 11); // default values for origin and bound
    }

    public KnapsackProblem(int n, int seed, int origin, int bound) {
        this.n = n;
        this.items = new ArrayList<>();
        Random random = new Random(seed);
        for (int i = 0; i < n; i++) {
            int value = random.nextInt(origin, bound);
            int weight = random.nextInt(origin, bound);
            Item newItem = new Item(i, value, weight);
            items.add(newItem);
        }
    }

    public Result solve(int capacity) {
        if (capacity < 0) {
            capacity = 0;
            // throw()
        }

        Result result = new Result(capacity);
        List<Item> sortedItems = new ArrayList<>(items);
        sortedItems.sort((a, b) -> Double.compare(b.getRatio(), a.getRatio()));

        for (Item item : sortedItems) {
            while (result.getTotalWeight() + item.getWeight() <= result.getCapacity()) {
                result.addItemToList(item);
            }
            if(result.getTotalWeight() == result.getCapacity()){
                break;
            }
        }
        return result;
    }

    @Override
    public String toString() {
        StringBuilder res = new StringBuilder();
        for (Item item : items) {
            res.append(item).append("\n");
        }
        return res.toString();
    }
}
