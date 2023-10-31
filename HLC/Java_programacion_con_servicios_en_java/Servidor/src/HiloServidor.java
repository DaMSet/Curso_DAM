import java.io.*;
import java.net.Socket;

public class HiloServidor extends Thread {
    Socket clientSocket;
    OutputStream outputStream;

    public HiloServidor(Socket clientSocket) throws IOException {
        this.clientSocket = clientSocket;
        outputStream = clientSocket.getOutputStream();
    }

    public void run() {
        try {
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));

            String resourceName = bufferedReader.readLine().split(" ")[1];

            File file = new File("files" + resourceName);

            if(file.exists()){
                FileInputStream fileInputStream = new FileInputStream(file);
                byte[] buffer = new byte[1024];
                int bytesRead;
                String response = "HTTP/1.1 200 OK\r\n\r\n";
                outputStream.write(response.getBytes());
                while ((bytesRead = fileInputStream.read(buffer)) != -1) {
                    outputStream.write(buffer, 0, bytesRead);
                }

                fileInputStream.close();
            }else{
                String response = "HTTP/1.1 404 Not Found\r\n\r\n{\"httpProtocol\":\"HTTP/1.1\",\"statusCode\": 404, \"message\":\"File not found!\"}";
                outputStream.write(response.getBytes());
            }

            bufferedReader.close();
            outputStream.close();
            clientSocket.close();

        } catch (Exception ex) {
            System.err.println(ex.getMessage());
        }
    }
}
