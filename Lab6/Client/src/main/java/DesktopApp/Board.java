package DesktopApp;

import javax.swing.*;
import java.awt.*;
import java.io.IOException;
import java.util.List;

public class Board {
    public int boardHeight = 10;
    public int boardWidth = 10;
    public int[][] board;
    public Point startPoint;
    public Point endPoint;
    public List<Point> path;

    public Board(int bHeight, int bWidth) {
        boardHeight = bHeight;
        boardWidth = bWidth;
        if (board!= null) {
            board = null;
        }
        board = new int[boardHeight][boardWidth];
        startPoint = new Point(0, 0);
        endPoint = new Point(boardHeight - 1, boardWidth - 1);
    }

    public void getPath(JButton[][] boardButtons) {
        int[][] newBoard = board;
        if(path != null && !path.isEmpty()) {
            clearPreviousPath(newBoard, boardButtons);
        }


        System.out.println("Board data:");
        for (int i = 0; i < boardHeight; i++) {
            for (int j = 0; j < boardWidth; j++) {
                System.out.print(newBoard[i][j] + " ");
            }
            System.out.println();
        }
        try {
            path = Client.getPath(newBoard, startPoint, endPoint);
            for (Point point : path) {
                boardButtons[point.x][point.y].setBackground(Color.GREEN);
            }
        } catch (IOException | ClassNotFoundException ex) {
            ex.printStackTrace();
        }
        System.out.println("Start point: [" + startPoint.x + ", " + startPoint.y + "]");
        System.out.println("End point: [" + endPoint.x + ", " + endPoint.y + "]");
    }

    private void clearPreviousPath(int[][] newBoard, JButton[][] boardButtons){
        for (Point point : path) {
            if (boardButtons[point.x][point.y].getBackground() == Color.GREEN) {
                if (newBoard[point.x][point.y] == 1) {
                    boardButtons[point.x][point.y].setBackground(Color.RED);
                } else {
                    boardButtons[point.x][point.y].setBackground(null);
                }
            }
        }
    }

    public void generateRandomBoard(JButton[][] boardButtons) {
        for (int i = 0; i < boardHeight; i++) {
            for (int j = 0; j < boardWidth; j++) {
                board[i][j] = (int) (Math.random() * 2); // generate 0 or 1 randomly
                if(board[i][j] == 1) {
                    boardButtons[i][j].setBackground(Color.RED);
                } else {
                    boardButtons[i][j].setBackground(null);
                }
            }
        }
    }

}
