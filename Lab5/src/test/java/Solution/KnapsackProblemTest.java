package Solution;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class KnapsackProblemTest {
    @Test
    public void testAtLeastOneItemReturned() {
        KnapsackProblem problem = new KnapsackProblem(5, 10, 1, 10);
        Result result = problem.solve(10);
        assertFalse(result.getItems().isEmpty());
    }

    @Test
    public void testEmptySolutionReturned() {
        KnapsackProblem problem = new KnapsackProblem(5, 10, 1, 10);
        Result result = problem.solve(0);
        assertEquals(0, result.getItems().size());
    }

    @Test
    public void testItemsWithinCertainBounds() {
        int lowerBound = 1;
        int upperBound = 10;
        KnapsackProblem originalProblem = new KnapsackProblem(5, 10, lowerBound, upperBound);

        Result originalResult = originalProblem.solve(10);

        for(Item item : originalResult.getItems()) {
            assertTrue(item.getValue() >= lowerBound && item.getValue() <= upperBound);
            assertTrue(item.getWeight() >= lowerBound && item.getWeight() <= upperBound);
        }
    }

    @Test
    public void testSpecificInstance() {
        KnapsackProblem problem = new KnapsackProblem(5, 10, 1, 10);
        Result result = problem.solve(10);

        assertEquals(1, result.getItems().getFirst().getId());
        assertEquals(7, result.getItems().getFirst().getValue());
        assertEquals(1, result.getItems().getFirst().getWeight());
        assertEquals(10, result.getItems().getFirst().getCount());
        assertEquals(10, result.getTotalWeight());
        assertEquals(70, result.getTotalValue());
    }
}