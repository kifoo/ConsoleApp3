package Solution;

import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.Random;

public class KnapsackProblem {
    private final List<Item> items;

    public KnapsackProblem(int n, int seed) {
        this(n, seed, 2, 11); // default values for origin and bound
    }

    public KnapsackProblem(int n, int seed, double origin, double bound) {
        this.items = new ArrayList<>();
        DecimalFormat df = new DecimalFormat("#.##");
        Random random = new Random(seed);
        for (int i = 0; i < n; i++) {
            double value = random.nextDouble() * (bound - origin) + origin; // Generate a random double between origin and bound
            double weight = random.nextDouble() * (bound - origin) + origin; // Generate a random double between origin and bound
            String formattedValue = df.format(value); // Format the value to have up to 2 decimal places
            String formattedWeight = df.format(weight); // Format the weight to have up to 2 decimal places
            double parsedValue = Double.parseDouble(formattedValue.replace(",", ".")); // Parse the formatted value back to a double, replacing commas with periods
            double parsedWeight = Double.parseDouble(formattedWeight.replace(",", ".")); // Parse the formatted weight back to a double, replacing commas with periods
            Item newItem = new Item(i, parsedValue, parsedWeight);
            items.add(newItem);
        }
    }

    public List<Item> getItems() {
        return items;
    }

    public Result solve(double capacity) {
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
