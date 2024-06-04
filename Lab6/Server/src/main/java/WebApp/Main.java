package WebApp;

import com.sun.net.httpserver.HttpExchange;
import com.sun.net.httpserver.HttpHandler;
import com.sun.net.httpserver.HttpServer;

import java.io.IOException;
import java.io.OutputStream;
import java.net.InetSocketAddress;
import java.util.concurrent.Executors;

public class Main {
    public static void main(String[] args) throws IOException {
        HttpServer httpServer = HttpServer.create(new InetSocketAddress("localhost", 8080), 0);

        httpServer.createContext("/index", new ServerHandler());
        httpServer.setExecutor(Executors.newSingleThreadExecutor());
        httpServer.start();
    }

    public static class ServerHandler implements HttpHandler {
        @Override
        public void handle(HttpExchange exchange) throws IOException {
            if("GET".equals(exchange.getRequestMethod())) {
                //handleGetRequest(exchange);
                OutputStream outputStream = exchange.getResponseBody();
                String responseToBeSentBack = "Hello from the other side";
                exchange.sendResponseHeaders(200, responseToBeSentBack.length());

                outputStream.write(responseToBeSentBack.getBytes());
                outputStream.flush();
                outputStream.close();

            } else if("POST".equals(exchange.getRequestMethod())) {
                //handlePostRequest(exchange);


            }
        }
    }
}