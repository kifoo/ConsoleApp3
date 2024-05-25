package org.example;

class Item {
    private int id;
    private int value;
    private int weight;
    private int count;

    public Item(int id, int value, int weight) {
        this.id = id;
        this.value = value;
        this.weight = weight;
        this.count = 0;
    }

    public int getId() {
        return id;
    }

    public int getValue() {
        return value;
    }

    public int getWeight() {
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
        return "Item {id: " + id + ", value: " + value + ", weight: " + weight + "}";
    }
}
