package Solution;

import java.text.DecimalFormat;

class Item {
    private int id;
    private double value;
    private double weight;
    private int count;

    public Item(int id, double value, double weight) {
        this.id = id;
        this.value = value;
        this.weight = weight;
        this.count = 0;
    }

    public int getId() {
        return id;
    }

    public double getValue() {
        return value;
    }

    public double getWeight() {
        return weight;
    }

    public double getRatio() {
        return (double) value / weight;
    }

    public int getCount() {
        return count;
    }

    public void updateCount() {
        count += 1;
    }

    @Override
    public String toString() {
        return "No." + id + ",\t value: " + value + ",\t weight: " + weight;
    }
}
