package Solution;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class KnapsackProblemTest {
    @Test
    public void testAtLeastOneItemReturned() {
        KnapsackProblem problem = new KnapsackProblem(5, 10, 1.0, 10.0);
        Result result = problem.solve(10.0);
        assertFalse(result.getItems().isEmpty());
    }

    @Test
    public void testEmptySolutionReturned() {
        KnapsackProblem problem = new KnapsackProblem(5, 10, 1.0, 10.0);
        Result result = problem.solve(0.0);
        assertEquals(0, result.getItems().size());
    }

    @Test
    public void testItemsWithinCertainBounds() {
        double lowerBound = 1;
        double upperBound = 10;
        KnapsackProblem originalProblem = new KnapsackProblem(5, 10, lowerBound, upperBound);

        Result originalResult = originalProblem.solve(10.0);

        for(Item item : originalResult.getItems()) {
            assertTrue(item.getValue() >= lowerBound && item.getValue() <= upperBound);
            assertTrue(item.getWeight() >= lowerBound && item.getWeight() <= upperBound);
        }
    }

    @Test
    public void testSpecificInstance() {
        KnapsackProblem problem = new KnapsackProblem(5, 10, 1.0, 10.0);
        Result result = problem.solve(10.0);

        assertEquals(0, result.getItems().getFirst().getId());
        assertEquals(7.57, result.getItems().getFirst().getValue());
        assertEquals(3.32, result.getItems().getFirst().getWeight());
        assertEquals(3, result.getItems().getFirst().getCount());
        assertEquals(9.959999999999999, result.getTotalWeight());
        assertEquals(22.71, result.getTotalValue());
    }
}