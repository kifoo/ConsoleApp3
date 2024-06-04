package Solution;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

public class Result {
    private int capacity;
    private int totalWeight;
    private int totalValue;
    private List<Item> result;

    public Result(int capacity){
        this.capacity = capacity;
        this.totalWeight = 0;
        this.totalValue = 0;
        this.result = new ArrayList<>();
    }

    public int getTotalWeight() {
        return totalWeight;
    }

    public int getTotalValue() {
        return totalValue;
    }

    public int getCapacity(){
        return capacity;
    }

    public List<Item> getItems() {
        return result;
    }

    public void addItemToList(Item addedItem){
        if(result.indexOf(addedItem) == -1){
            result.add(addedItem);
        }
        result.get(result.indexOf(addedItem)).updateCount();
        totalWeight += addedItem.getWeight();
        totalValue += addedItem.getValue();
    }

    @Override
    public String toString() {
        StringBuilder res = new StringBuilder();
        res.append("Total value: ").append(totalValue).append("\n");
        res.append("Total weight: ").append(totalWeight).append("\n");
        res.append("Items: ");
        for (Item item : result) {
            res.append("\nItem ").append(item.getId()).append(" => ").append(item.getCount()).append(" times");
        }
        return res.toString();
    }

}
