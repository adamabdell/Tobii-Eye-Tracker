import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;

public class UDPReciever implements Runnable{
	byte[] streambuffer = new byte[Byte.MAX_VALUE-1];
    DatagramSocket streamSocket;
    DatagramPacket streamPacket;
	DataInputStream inputStream;
	DataOutputStream OutputStream;
	String data;
	
	public UDPReciever(InetAddress add,DatagramSocket d) {
		streamSocket=d;
		streamPacket = new DatagramPacket(streambuffer, streambuffer.length);
		System.out.println("\tNew Datagram socket on "+d.getLocalPort());
	}
	public UDPReciever(InetAddress add,int port) throws SocketException {
		this(add,new DatagramSocket(port));
	}

	public void run() {
		try {
			PrintWriter writer = new PrintWriter(String.valueOf(streamSocket.getLocalPort())+".txt");
			writer.print(45534);
			while(true) {
				streamSocket.receive(streamPacket);
				byte[] bytes = streamPacket.getData();
				data=new String(bytes, 0, streamPacket.getLength());
				System.out.println(streamPacket.getAddress()+": "+data);
				writer.write(data);
				writer.flush();
			}
			
		} catch (IOException e) {
				e.printStackTrace();
		}	
		
	}

	

	
	//Recieve data from student
	public String getStudentData() {
		return data;}

}
