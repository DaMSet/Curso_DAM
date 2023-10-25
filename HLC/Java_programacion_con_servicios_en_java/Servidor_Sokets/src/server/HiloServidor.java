package server;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class HiloServidor extends Thread{
	
	BufferedReader entrada;
	PrintWriter salida;
	
	Socket socket = null;

	public HiloServidor(Socket s) throws IOException{
		
		socket = s;
		salida = new PrintWriter(socket.getOutputStream(), true);
		entrada = new BufferedReader(new InputStreamReader(socket.getInputStream()));
	}

}
