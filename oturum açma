import java.awt.BorderLayout;
import java.awt.EventQueue;
 
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.Font;
import javax.swing.JButton;
import java.awt.Window.Type;
import javax.swing.SwingConstants;
import java.awt.Color;
import com.toedter.calendar.JCalendar;
import javax.swing.JPasswordField;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
 
public class loginFrame extends JFrame {
 
             private JPanel contentPane;
             private JTextField txtID;
             private JPasswordField passwordField;
 
             /**
             * Launch the application.
             */
             public static void main(String[] args) {
                           EventQueue.invokeLater(new Runnable() {
                                        public void run() {
                                                     try {
                                                                  loginFrame frame = new loginFrame();
                                                                  frame.setVisible(true);
                                                     } catch (Exception e) {
                                                                  e.printStackTrace();
                                                     }
                                        }
                           });
             }
 
             /**
             * Create the frame.
             */
             public loginFrame() {
                           setTitle("AQUARIUS APPOINTMENT SYSTEM");
                           setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                           setBounds(100, 100, 560, 400);
                           contentPane = new JPanel();
                           contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
                           setContentPane(contentPane);
                           contentPane.setLayout(null);
                          
                           JPanel panel = new JPanel();
                           panel.setBackground(new Color(230, 230, 250));
                           panel.setBounds(0, 0, 560, 378);
                           contentPane.add(panel);
                           panel.setLayout(null);
                          
                           txtID = new JTextField();
                           txtID.setFont(new Font("Dialog", Font.PLAIN, 14));
                           txtID.setBounds(263, 85, 155, 30);
                           panel.add(txtID);
                           txtID.setColumns(10);
                          
                           JLabel LabelID = new JLabel("PERSONAL ID :");
                           LabelID.setHorizontalAlignment(SwingConstants.CENTER);
                           LabelID.setFont(new Font("Dialog", Font.BOLD, 14));
                           LabelID.setBounds(134, 84, 117, 30);
                           panel.add(LabelID);
                          
                           JLabel LabelPassword = new JLabel("PASSWORD :");
                           LabelPassword.setHorizontalAlignment(SwingConstants.CENTER);
                           LabelPassword.setFont(new Font("Dialog", Font.BOLD, 14));
                           LabelPassword.setBounds(134, 141, 117, 30);
                           panel.add(LabelPassword);
                           passwordField = new JPasswordField();
                           passwordField.setBounds(263, 141, 155, 30);
                           panel.add(passwordField);
                          
                           JButton Loginbtn = new JButton("LOG IN");
                           Loginbtn.addActionListener(new ActionListener() {
                           	public void actionPerformed(ActionEvent e) {
                           		String id,password;
                           		password=passwordField.getText();
                           		id=txtID.getText();
                           		Boolean a=connection.personalenter(id, password);
                           		if(a) {
                           		
                           		
                           		
                           		mainFrame main = new mainFrame();
                           		main.setVisible(true);
                           		dispose();
                           		}
                           		else {
                           			JOptionPane.showMessageDialog(null, "The information is wrong.Please,try again");
                           			dispose();
                           			loginFrame frame=new loginFrame();
                           			frame.setVisible(true);
                           			
                           		}                           		
                           	}
                           });
                           Loginbtn.setFont(new Font("Dialog", Font.BOLD, 14));
                           Loginbtn.setBounds(110, 220, 165, 48);
                           panel.add(Loginbtn);
                          
                           JButton Forgotbtn = new JButton("FORGET PASSWORD");
                           Forgotbtn.addActionListener(new ActionListener() {
                           	public void actionPerformed(ActionEvent e) {
                           		
                           		ForgetPassFrame pas = new ForgetPassFrame();
                           		pas.setVisible(true);
                           		dispose();
                           		
                           	}
                           });
                           Forgotbtn.setFont(new Font("Dialog", Font.BOLD, 14));
                           Forgotbtn.setBounds(286, 220, 165, 48);
                           panel.add(Forgotbtn);
                           
                           
             }
}
