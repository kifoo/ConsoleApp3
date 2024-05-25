package org.example;

import javax.swing.*;
import java.awt.*;
import java.text.NumberFormat;

public class KnapsackGUI {
    private JFrame frame;
    private JFormattedTextField nField;
    private JFormattedTextField capacityField;
    private JFormattedTextField seedField;
    private JFormattedTextField originField = new JFormattedTextField(2);
    private JFormattedTextField boundField = new JFormattedTextField(11);
    private JTextArea outputArea;
    private JTextArea problemArea;

    public KnapsackGUI() {
        NumberFormat format = NumberFormat.getIntegerInstance();
        format.setGroupingUsed(false); // to disable comma grouping
        nField = new JFormattedTextField(format);
        capacityField = new JFormattedTextField(format);
        seedField = new JFormattedTextField(format);

        createGUI();
    }

    private void createGUI() {
        frame = new JFrame("Knapsack Problem");
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
        int n = Integer.parseInt(nField.getText());
        int capacity = Integer.parseInt(capacityField.getText());
        int seed = Integer.parseInt(seedField.getText());
        int origin = Integer.parseInt(originField.getText());
        int bound = Integer.parseInt(boundField.getText());

        KnapsackProblem problem = new KnapsackProblem(n, seed, origin, bound);
        problemArea.setText(problem.toString());

        Result result = problem.solve(capacity);
        outputArea.setText(result.toString());
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new KnapsackGUI();
            }
        });
    }
}
