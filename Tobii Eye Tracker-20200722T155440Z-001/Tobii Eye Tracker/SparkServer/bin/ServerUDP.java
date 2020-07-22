import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;

public class ServerUDP implements Runnable{
	byte[] streambuffer = new byte[Byte.MAX_VALUE-1];
    DatagramSocket streamSocket;
    DatagramPacket streamPacket;
	DataInputStream inputStream;
	DataOutputStream OutputStream;
	InetAddress ip;
	String data;
	
	public ServerUDP(InetAddress i,DatagramSocket d) {
		ip=i;
		streamSocket=d;
		streamPacket = new DatagramPacket(streambuffer, streambuffer.length);
		System.out.println("\t\tNew Datagram socket on "+d.getLocalPort());
	}
	public ServerUDP(InetAddress i,int port) throws SocketException {
		this(i,new DatagramSocket(port));
	}

	public void run() {
		try {
			//Create a print writer to print to a file
			PrintWriter writer = new PrintWriter(String.valueOf(streamSocket.getLocalPort())+".txt");
			writer.print(45534);
			while(true) {
				streamSocket.receive(streamPacket);
				byte[] recieved = streamPacket.getData();
				data=new String(recieved, 0, streamPacket.getLength());
				System.out.println("\t\t"+streamPacket.getAddress()+": "+data);
				
				writer.write(data);
				writer.flush();
				//streamSocket.send(new DatagramPacket(recieved , recieved.length,ip,streamSocket.getLocalPort()));
			}
			
			
		} catch (IOException e) {
				e.printStackTrace();
		}	
		
	}

	

	
	//Recieve data from student
	public String getStudentData() {
		return data;}

}
