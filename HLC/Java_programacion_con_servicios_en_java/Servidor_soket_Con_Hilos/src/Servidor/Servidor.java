package Servidor;

import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {

	public static void main(String[] args) throws IOException {
		
		
		ServerSocket serverSocket = new ServerSocket(80);
		
		while (true) {
		    Socket clientSocket = serverSocket.accept();
		    // Crear un nuevo hilo para manejar la solicitud del cliente
		    Thread thread = new Thread(() -> {
		        try {
		            // Procesar la solicitud del cliente aquí
		        	
		        	
		        	BufferedReader in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
		        	String inputLine;
		        	while ((inputLine = in.readLine()) != null) {
		        	    if (inputLine.startsWith("GET")) {
		        	        String url = inputLine.split(" ")[1];
		        	        // Procesar la URL solicitada aquí
		        	        
		        	        PrintWriter out = new PrintWriter(clientSocket.getOutputStream(), true);
				        	out.println("HTTP/1.1 200 OK");
				        	out.println("Content-Type: text/html");
				        	out.println("");

				        	// Cargar el contenido de la página web solicitada aquí
				        	String content = "<html><body><h1>Hola Mundo!</h1></body></html>";

				        	out.println(content);
		        	     
				        	in.close();
				        	out.close();
				        	clientSocket.close();	
				        	
		        	    }
		        	}
		        	
		        	
		        	
		        	

		        	
		        	
		        	
		        	
		        } catch (IOException e) {
		            e.printStackTrace();
		        }
		    });
		    thread.start();
		}

		
		
	}

}
