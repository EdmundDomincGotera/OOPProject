   M S B A M L   `   `   `  ����F  BOOP_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:OOP_ProjectOOP_Project  5   	       OOP_Project.Add_Customer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:OOP_Project     5   	     � Title$  Add Customer��5   	   $	��700��6   $	��500��6+   $��12(�67   ���#04c582 � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   .��5      � .+�5   
   �� ���#2e3137 �� CornerRadius$ 20��6&   $��20q�68   ._�5      �� $��20q�6   .+�5      �� $��Login��6   
�������$��30(�6;   $��Center=�6I   �� 5      6   5      5      �� 5   
   $��
First Name��6   $��20(�5      
�������$��Center=�5      $	��Top=�5      $��0, 120, 0, 0q�5      �� 5   
   $��Middle Name��6   $��20(�5      
�������$��Center=�5      $��0, 180, 0, 0q�5      $	��Top=�5       J� RenderTransformOrigin$ 0.543,-0.635&�5       �� 5"   
   $��	Last Name��6   $��20(�5#      
�������$��Center=�5$      $	��Top=�5%      $��0, 240, 0, 0q�5&      �� 5(   
   $��	Birthdate��6   $��20(�5)      
�������$��Center=�5*      $	��Top=�5+      $��0, 300, 0, 0q�5,      (  "System.Windows.Controls.DatePicker  5.   
   -   5        $��
dpBirthday��5.      ���#545d6a$��Center=�50      $	��Top=�51      $��0, 340, 0, 0q�52      �� 54   
   $��Address��6   $��20(�55      
�������$��Center=�56      $	��Top=�57      $��0, 370, 0, 0q�58      �� 5:   
   -   5        $��
txtAddress��5:      ���#545d6a$��Center=�5<      $��23��5=      $��0, 410, 0, 0q�6    �� TextWrapping$
 Wrap=�5>      $�� ��6&   $	��Top=�5?      $	��120��5@      �� 5B   
   -   5        $��txtFirstName��5B      ���#545d6a$��Center=�5D      $��23��5E      $��0, 160, 0, 0q�6   $
 Wrap=�5F      $	��Top=�5G      $	��120��5H      �� 5J   
   -   5        $��txtMiddleName��5J      ���#545d6a$��Center=�5L      $��23��5M      $��0, 220, 0, 0q�6   $
 Wrap=�5N      $�� ��6&   $	��Top=�5O      $	��120��5P      �� 5R   
   -   5        $��txtLastName��5R      ���#545d6a$��Center=�5T      $��23��5U      $��0, 280, 0, 0q�6   $
 Wrap=�5V      $�� ��6&   $	��Top=�5W      $	��120��5X      �� 5Z   
   -   5        $	��Add��5Z      $��Center=�5[      $��0, 560, 0, 0q�5\      $	��Top=�5]      $	��100��6)   $��30��5_      5a      5b      