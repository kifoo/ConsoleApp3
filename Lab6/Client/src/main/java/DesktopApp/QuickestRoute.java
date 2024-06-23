package DesktopApp;

import javax.swing.*;
import javax.swing.event.ChangeEvent;
import javax.swing.event.ChangeListener;
import java.awt.*;
import java.awt.event.*;

public class QuickestRoute extends JFrame {
    private JPanel boardIndicesPanel;
    private JPanel boardPanel;
    private JButton[][] boardButtons;
    private JToggleButton startPointButton;
    private JToggleButton endPointButton;
    private JToggleButton blockPathButton;
    private JLabel startXField;
    private JLabel startYField;
    private JLabel endXField;
    private JLabel endYField;
    private Board board;
    private JFrame frame;

    public QuickestRoute() {
        frame = new JFrame("Get the shortest path");
        setLayout(new BorderLayout());

        JPanel titlePanel = getTitlePanel();
        frame.add(titlePanel, BorderLayout.NORTH);

        frame.add(initMenuPanel(), BorderLayout.WEST);

        if( board == null) {
            board = new Board(10, 10);
        }

        showBoardSizeDialog();

        frame.setSize(1200, 1000);
        frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
        frame.setVisible(true);
    }

    private void initBoard() {
        boardIndicesPanel = new JPanel(new BorderLayout());
        boardIndicesPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        // Initialize the board and boardButtons arrays
        if (boardButtons!= null) {
            boardButtons = null;
        }
        boardButtons = new JButton[board.boardHeight][board.boardWidth];

        // Create a panel for the row indices
        JPanel rowIndicesPanel = new JPanel(new GridLayout(board.boardHeight, 1));
        for (int i = 0; i < board.boardHeight; i++) {
            JLabel label = new JLabel("  " + String.valueOf(i) + "  ");
            label.setHorizontalAlignment(JLabel.CENTER);
            rowIndicesPanel.add(label);
        }

        // Create a panel for the column indices
        JPanel columnIndicesPanel = new JPanel(new GridLayout(1, board.boardWidth));
        for (int i = 0; i < board.boardWidth; i++) {
            JLabel label = new JLabel("\n" + String.valueOf(i));
            label.setHorizontalAlignment(JLabel.CENTER);
            columnIndicesPanel.add(label);
        }
        boardIndicesPanel.add(rowIndicesPanel, BorderLayout.WEST);
        boardIndicesPanel.add(columnIndicesPanel, BorderLayout.NORTH);

        boardPanel = new JPanel(new GridLayout(board.boardHeight, board.boardWidth));
        for (int i = 0; i < board.boardHeight; i++) {
            for (int j = 0; j < board.boardWidth; j++) {
                JButton button = new JButton();
                button.addActionListener(new ActionListener() {
                    @Override
                    public void actionPerformed(ActionEvent e) {
                        JButton clickedButton = (JButton) e.getSource();
                        int x = -1, y = -1;
                        for (int i = 0; i < board.boardHeight; i++) {
                            for (int j = 0; j < board.boardWidth; j++) {
                                if (boardButtons[i][j] == clickedButton) {
                                    x = i;
                                    y = j;
                                    break;
                                }
                            }
                        }
                        if (blockPathButton.isSelected()) {
                            if (clickedButton.getBackground()!= Color.RED) {
                                clickedButton.setBackground(Color.RED);
                                board.board[x][y] = 1;
                            } else {
                                clickedButton.setBackground(null);
                                board.board[x][y] = 0;
                            }
                        }
                        if(startPointButton.isSelected()) {
                            if (clickedButton.getBackground()!= Color.RED) {
                                if(boardButtons[board.startPoint.x][board.startPoint.y].getBackground() != Color.RED) {
                                    boardButtons[board.startPoint.x][board.startPoint.y].setBackground(null);
                                }
                                clickedButton.setBackground(Color.GREEN);
                                startXField.setText(String.valueOf(x));
                                startYField.setText(String.valueOf(y));
                                board.startPoint = new Point(x, y);
                            }
                            else{
                                JOptionPane.showMessageDialog(QuickestRoute.this, "Invalid input for start point. \nIt should not be a blocked path.");
                            }
                        }
                        if(endPointButton.isSelected()) {
                            if (clickedButton.getBackground()!= Color.RED) {
                                if(boardButtons[board.endPoint.x][board.endPoint.y].getBackground() != Color.RED) {
                                    boardButtons[board.endPoint.x][board.endPoint.y].setBackground(null);
                                }
                                clickedButton.setBackground(Color.GREEN);
                                endXField.setText(String.valueOf(x));
                                endYField.setText(String.valueOf(y));
                                board.endPoint = new Point(x, y);
                            }
                            else{
                                JOptionPane.showMessageDialog(QuickestRoute.this, "Invalid input for end point. \nIt should not be a blocked path.");
                            }
                        }
                    }
                });
                boardButtons[i][j] = button;
                boardPanel.add(button);
            }
        }

        boardIndicesPanel.add(boardPanel, BorderLayout.CENTER);
        frame.add(boardIndicesPanel, BorderLayout.CENTER);
        revalidate();
        repaint();
    }

    private void showBoardSizeDialog() {
        JTextField heightField = new JTextField(String.valueOf(board.boardHeight));
        JTextField widthField = new JTextField(String.valueOf(board.boardWidth));
        Object[] message = {
                "Height:", heightField,
                "Width:", widthField
        };

        int option = JOptionPane.showConfirmDialog(null, message, "Enter Board Size", JOptionPane.OK_CANCEL_OPTION);
        if (option == JOptionPane.OK_OPTION) {
            try {
                int newHeight = Integer.parseInt(heightField.getText().trim());
                int newWidth = Integer.parseInt(widthField.getText().trim());
                if (newHeight > 0 && newWidth > 0) {
                    board = new Board(newHeight, newWidth);
                    initBoard();
                } else {
                    JOptionPane.showMessageDialog(this, "Invalid input for board size. \nIt should be a positive integer.");
                }
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(this, "Invalid input for board size. \nIt should be a valid integer.");
            }
        }
    }

    private JPanel initMenuPanel() {
        JPanel menuPanel = new JPanel(new GridLayout(0, 1));
        menuPanel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        menuPanel.setPreferredSize(new Dimension(250, menuPanel.getPreferredSize().height));

        changeBoardSizePanel(menuPanel);
        getStartPointPanel(menuPanel);
        getEndPointPanel(menuPanel);
        menuPanel.add(new JLabel("Block or unblock points on the board."));
        getBlockPathPanel(menuPanel);
        menuPanel.add(new JLabel("Get a random board."));
        getRandomBoardButton(menuPanel);
        menuPanel.add(new JSeparator());
        getSendButton(menuPanel);

        return menuPanel;
    }

    private void changeBoardSizePanel(JPanel menuPanel){
        JButton changeSizeButton = new JButton("Change Size");
        changeSizeButton.setMargin(new Insets(10, 10, 10, 10));
        changeSizeButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                frame.dispose();
                new QuickestRoute();
            }
        });
        menuPanel.add(changeSizeButton);
    }


    private void getBlockPathPanel(JPanel menuPanel){
        blockPathButton = new JToggleButton("Block path");
        blockPathButton.setMargin(new Insets(10, 10, 10, 10));
        blockPathButton.addChangeListener(new ChangeListener() {
            @Override
            public void stateChanged(ChangeEvent e) {
                if (blockPathButton.isSelected()) {
                    blockPathButton.setForeground(Color.RED);
                    startPointButton.setSelected(false);
                    startPointButton.setForeground(Color.BLACK);
                    endPointButton.setSelected(false);
                    endPointButton.setForeground(Color.BLACK);
                } else {
                    blockPathButton.setForeground(Color.BLACK);
                }
            }
        });
        blockPathButton.setAlignmentX(Component.CENTER_ALIGNMENT);
        menuPanel.add(blockPathButton);
    }
    private void getStartPointPanel(JPanel menuPanel){
        JPanel pointsStartPanel = new JPanel(new GridLayout(1, 4));

        JLabel xPointLabel = new JLabel("X:");
        xPointLabel.setBorder(BorderFactory.createEmptyBorder(0, 0, 0, 2));
        JLabel yPointLabel = new JLabel("Y:");
        yPointLabel.setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 2));

        startXField = new JLabel("0");
        startYField = new JLabel("0");

        pointsStartPanel.add(xPointLabel);
        pointsStartPanel.add(startXField);
        pointsStartPanel.add(yPointLabel);
        pointsStartPanel.add(startYField);

        pointsStartPanel.setAlignmentX(Component.CENTER_ALIGNMENT);
        pointsStartPanel.setBorder(BorderFactory.createEmptyBorder(0, 5, 5, 5));

        startPointButton = new JToggleButton("Choose start Point");
        startPointButton.setMargin(new Insets(10, 10, 10, 10));
        startPointButton.addChangeListener(new ChangeListener() {
            @Override
            public void stateChanged(ChangeEvent e) {
                if (startPointButton.isSelected()) {
                    startPointButton.setForeground(Color.GREEN);
                    blockPathButton.setSelected(false);
                    blockPathButton.setForeground(Color.BLACK);
                    endPointButton.setSelected(false);
                    endPointButton.setForeground(Color.BLACK);
                }
                else{
                    startPointButton.setForeground(Color.BLACK);
                }
            }
        });

        menuPanel.add(new JLabel("Start position:"));
        menuPanel.add(pointsStartPanel);
        menuPanel.add(startPointButton);
    }
    private void getEndPointPanel(JPanel menuPanel){
        JPanel pointsEndPanel = new JPanel(new GridLayout(1, 4));

        JLabel xPointLabel = new JLabel("X");
        xPointLabel.setBorder(BorderFactory.createEmptyBorder(0, 0, 0, 2));
        JLabel yPointLabel = new JLabel("Y");
        yPointLabel.setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 2));

        endXField = new JLabel("9");
        endYField = new JLabel("9");

        pointsEndPanel.add(xPointLabel);
        pointsEndPanel.add(endXField);
        pointsEndPanel.add(yPointLabel);
        pointsEndPanel.add(endYField);

        pointsEndPanel.setAlignmentX(Component.CENTER_ALIGNMENT);
        pointsEndPanel.setBorder(BorderFactory.createEmptyBorder(0, 5, 5, 5));

        endPointButton = new JToggleButton("Choose end Point");
        endPointButton.setMargin(new Insets(10, 10, 10, 10));
        endPointButton.addChangeListener(new ChangeListener() {
            @Override
            public void stateChanged(ChangeEvent e) {
                if (endPointButton.isSelected()) {
                    endPointButton.setForeground(Color.GREEN);
                    blockPathButton.setSelected(false);
                    blockPathButton.setForeground(Color.BLACK);
                    startPointButton.setSelected(false);
                    startPointButton.setForeground(Color.BLACK);
                }
                else{
                    endPointButton.setForeground(Color.BLACK);
                }
            }
        });

        menuPanel.add(new JLabel("End position:"));
        menuPanel.add(pointsEndPanel);
        menuPanel.add(endPointButton);
    }
    private void getSendButton(JPanel menuPanel){
        JButton sendButton = new JButton("Send");
        sendButton = new JButton("Send");
        sendButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    board.getPath(boardButtons);
                } catch (NumberFormatException ex) {
                    JOptionPane.showMessageDialog(QuickestRoute.this, "Invalid input for start or end point. \nIt should be a valid integer.");
                }
            }
        });
        sendButton.setMargin(new Insets(10, 10, 10, 10));
        menuPanel.add(sendButton);
    }

    private void getRandomBoardButton(JPanel menuPanel){
        JButton randomBoardButton = new JButton("Random Board");
        randomBoardButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                board.generateRandomBoard(boardButtons);
            }
        });
        randomBoardButton.setMargin(new Insets(10, 10, 10, 10));
        menuPanel.add(randomBoardButton);
    }

    private JPanel getTitlePanel(){
        JPanel titlePanel = new JPanel();
        titlePanel.setLayout(new BoxLayout(titlePanel, BoxLayout.Y_AXIS)); // use BoxLayout to center vertically

        JLabel titleLabel = new JLabel("Get the shortest path");
        titleLabel.setFont(new Font("Arial", Font.BOLD, 24)); // set font to Arial, bold, and size 24
        titleLabel.setAlignmentX(Component.CENTER_ALIGNMENT); // center horizontally

        JButton infoButton = new JButton("Info");
        infoButton.setToolTipText("How to play");
        infoButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                showHowToPlayDialog();
            }
        });

        titlePanel.add(Box.createVerticalGlue()); // add glue to push the title to the center
        titlePanel.add(titleLabel);
        titlePanel.add(infoButton);
        titlePanel.add(Box.createVerticalGlue()); // add glue to push the title to the center

        return titlePanel;
    }

    private void showHowToPlayDialog() {
        String howToPlayText = "How to play:\n"
                + "1. Choose a board size.\n"
                + "2. Set the start and end points.\n"
                + "3. Click the 'Send' button to find the shortest path.\n"
                + "4. Click on the board to block or unblock paths.\n"
                + "5. You can also generate a random board by clicking the 'Random Board' button.";
        JOptionPane.showMessageDialog(this, howToPlayText, "How to play", JOptionPane.INFORMATION_MESSAGE);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new QuickestRoute();
            }
        });
    }
}