package WebApp;

import java.awt.*;
import java.io.IOException;
import java.util.List;
import java.io.*;
import java.net.*;
import java.util.*;

public class Server {
    public static void main(String[] args) throws IOException {
        ServerSocket serverSocket = new ServerSocket(8000);
        System.out.println("Server started. Waiting for clients...");

        while (true) {
            Socket socket = serverSocket.accept();
            System.out.println("Client connected.");

            ObjectInputStream inputStream = new ObjectInputStream(socket.getInputStream());
            ObjectOutputStream outputStream = new ObjectOutputStream(socket.getOutputStream());

            try {
                int[][] table = (int[][]) inputStream.readObject();
                Point startPoint = (Point) inputStream.readObject();
                Point endPoint = (Point) inputStream.readObject();

                List<Point> path = getPath(table, startPoint, endPoint);

                outputStream.writeObject(path);
            } catch (ClassNotFoundException e) {
                e.printStackTrace();
            } catch (IOException e) {
                System.out.println("Error processing request: " + e.getMessage());
            } finally {
                socket.close();
            }
        }
    }

    private static List<Point> getPath(int[][] table, Point startPoint, Point endPoint) {
        int rows = table.length;
        int cols = table[0].length;
        int[][] gScore = new int[rows][cols];           // cost for reaching each cell from start point
        int[][] hScore = new int[rows][cols];           // heuristic values of each cell - estimated value for reaching the end point
        int[][] fScore = new int[rows][cols];           // total cost of reaching each cell
        boolean[][] visited = new boolean[rows][cols];  // visited cells
        Point[][] cameFrom = new Point[rows][cols];     // previous cell for each cell

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                gScore[i][j] = Integer.MAX_VALUE;
                hScore[i][j] = heuristic(i, j, endPoint.x, endPoint.y, rows);
                fScore[i][j] = Integer.MAX_VALUE;
            }
        }

        gScore[startPoint.x][startPoint.y] = 0;
        fScore[startPoint.x][startPoint.y] = hScore[startPoint.x][startPoint.y];

        PriorityQueue<Point> toVisit = new PriorityQueue<>((p1, p2) -> fScore[p1.x][p1.y] - fScore[p2.x][p2.y]);
        toVisit.add(startPoint);

        while (!toVisit.isEmpty()) {
            Point current = toVisit.poll();
            if (current.equals(endPoint)) {
                return reconstructPath(cameFrom, current);
            }

            visited[current.x][current.y] = true;

            for (Point neighbor : getNeighbors(table, current)) {
                if (visited[neighbor.x][neighbor.y]) {
                    continue;
                }

                int tempGScore = gScore[current.x][current.y] + 1;
                if (tempGScore < gScore[neighbor.x][neighbor.y]) {
                    cameFrom[neighbor.x][neighbor.y] = current;
                    gScore[neighbor.x][neighbor.y] = tempGScore;
                    fScore[neighbor.x][neighbor.y] = gScore[neighbor.x][neighbor.y] + hScore[neighbor.x][neighbor.y];
                    toVisit.add(neighbor);
                }
            }
        }

        return new ArrayList<>();
    }

    private static List<Point> reconstructPath(Point[][] cameFrom, Point current) {
        List<Point> path = new ArrayList<>();
        path.add(current);
        while (cameFrom[current.x][current.y]!= null) {
            current = cameFrom[current.x][current.y];
            path.add(0, current);
        }
        return path;
    }

    private static int heuristic(int x1, int y1, int x2, int y2, int rows) {
        return Math.abs(x1 / rows - x2 / rows) + Math.abs(y1 % rows - y2 % rows);
    }

    private static List<Point> getNeighbors(int[][] table, Point point) {
        List<Point> neighbors = new ArrayList<>();
        for (int dx = -1; dx <= 1; dx++) {
            for (int dy = -1; dy <= 1; dy++) {
                if ((dx == 0 && dy == 0) || (dx != 0 && dy != 0)) {
                    continue;
                }

                int x = point.x + dx;
                int y = point.y + dy;

                if (x >= 0 && x < table.length && y >= 0 && y < table[0].length && table[x][y] == 0) {
                    neighbors.add(new Point(x, y));
                }
            }
        }
        return neighbors;
    }
}