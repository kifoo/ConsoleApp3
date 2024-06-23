package DesktopApp;

import java.awt.*;
import java.io.*;
import java.net.*;
import java.util.List;

public class Client {
    public static List<Point> getPath(int[][] table, Point startPoint, Point endPoint) throws IOException, ClassNotFoundException {
        Socket socket = new Socket("localhost", 8000);
        System.out.println("Connected to server.");

        ObjectOutputStream outputStream = new ObjectOutputStream(socket.getOutputStream());
        ObjectInputStream inputStream = new ObjectInputStream(socket.getInputStream());

        outputStream.writeObject(table);
        outputStream.writeObject(startPoint);
        outputStream.writeObject(endPoint);

        List<Point> path = (List<Point>) inputStream.readObject();

        System.out.println("Path: " + path);

        socket.close();
        return path;
    }
}
