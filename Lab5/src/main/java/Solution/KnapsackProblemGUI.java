package Solution;

import javax.swing.*;
import java.awt.*;
import java.text.*;

public class KnapsackProblemGUI {
    private final JFormattedTextField nField;
    private final JFormattedTextField capacityField;
    private final JFormattedTextField seedField;
    private final JFormattedTextField originField;
    private final JFormattedTextField boundField;
    private JTextArea outputArea;
    private JTextArea problemArea;

    public KnapsackProblemGUI() {
        NumberFormat formatInt = NumberFormat.getIntegerInstance();
        formatInt.setGroupingUsed(false); // to disable comma grouping

        DecimalFormatSymbols symbols = new DecimalFormatSymbols();
        symbols.setDecimalSeparator('.');
        DecimalFormat formatDouble = new DecimalFormat("#.###");;
        formatDouble.setGroupingUsed(false);
        formatDouble.setDecimalFormatSymbols(symbols);

        nField = new JFormattedTextField(formatInt);
        seedField = new JFormattedTextField(formatInt);
        capacityField = new JFormattedTextField(formatDouble);
        originField = new JFormattedTextField(formatDouble);
        boundField = new JFormattedTextField(formatDouble);

        originField.setValue(2.0);
        boundField.setValue(11.0);

        createGUI();
    }

    private void createGUI() {
        JFrame frame = new JFrame("Knapsack Problem");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLayout(new GridLayout(1, 2));

        JPanel inputPanel = createInputPanel();

        JPanel changeBoundsPanel = changeBoundsPanel();

        JScrollPane outputScrollPane = createOutputPanel();

        JScrollPane problemScrollPane = createProblemPanel();

        JPanel leftPanel = new JPanel(new BorderLayout());
        leftPanel.add(inputPanel, BorderLayout.NORTH);
        leftPanel.add(outputScrollPane, BorderLayout.CENTER);

        JPanel rightPanel = new JPanel(new BorderLayout());
        rightPanel.add(changeBoundsPanel, BorderLayout.NORTH);
        rightPanel.add(problemScrollPane, BorderLayout.CENTER);

        frame.add(leftPanel);
        frame.add(rightPanel);
        frame.pack();
        frame.setPreferredSize(new Dimension(800, 1200));
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }

    private JPanel changeBoundsPanel(){
        JPanel changeBoundsPanel = new JPanel(new GridLayout(1, 2, 5, 5));
        changeBoundsPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        addLabeledField(changeBoundsPanel, "Lower bound:", originField);
        addLabeledField(changeBoundsPanel, "Upper bound:", boundField);

        return changeBoundsPanel;
    }
    private JPanel createInputPanel(){
        JPanel inputPanel = new JPanel(new GridLayout(4, 2, 5, 5));
        inputPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));

        addLabeledField(inputPanel, "Number of items:", nField);
        addLabeledField(inputPanel, "Capacity:", capacityField);
        addLabeledField(inputPanel, "Seed:", seedField);

        JButton solveButton = new JButton("Solve");
        solveButton.addActionListener(e -> solveProblem());
        inputPanel.add(solveButton);

        return inputPanel;
    }

    private JScrollPane createOutputPanel(){
        outputArea = new JTextArea(10, 20);
        outputArea.setEditable(false);
        JScrollPane outputScrollPane = new JScrollPane(outputArea);
        outputScrollPane.setBorder(BorderFactory.createTitledBorder("Output"));
        return outputScrollPane;
    }

    private JScrollPane createProblemPanel(){
        problemArea = new JTextArea(10, 20);
        problemArea.setEditable(false);
        JScrollPane problemScrollPane = new JScrollPane(problemArea);
        problemScrollPane.setBorder(BorderFactory.createTitledBorder("Problem"));
        return problemScrollPane;
    }

    private void addLabeledField(JPanel panel, String labelText, JFormattedTextField textField) {
        JLabel label = new JLabel(labelText);
        panel.add(label);
        panel.add(textField);
    }

    private void solveProblem() {
        if (nField.getText() == null || nField.getText().isEmpty() ||
                capacityField.getText() == null || capacityField.getText().isEmpty() ||
                seedField.getText() == null || seedField.getText().isEmpty() ||
                originField.getText() == null || originField.getText().isEmpty() ||
                boundField.getText() == null || boundField.getText().isEmpty()) {
            JOptionPane.showMessageDialog(null, "Please input data in all fields.");
            return;
        }

        int n = Integer.parseInt(nField.getText());
        double capacity = Double.parseDouble(capacityField.getText());
        int seed = Integer.parseInt(seedField.getText());
        double origin = Double.parseDouble(originField.getText());
        double bound = Double.parseDouble(boundField.getText());

        KnapsackProblem problem = new KnapsackProblem(n, seed, origin, bound);
        problemArea.setText(problem.toString());

        Result result = problem.solve(capacity);
        outputArea.setText(result.toString());
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new KnapsackProblemGUI();
            }
        });
    }
}
