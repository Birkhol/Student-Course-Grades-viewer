   M S B A M L   `   `   `  ����I  ELINQassignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LINQassignmentLINQassignment  5   	       LINQassignment.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LINQassignment     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��25��6.   $	��Top=�6:   .+�5      �� -   5        $��Search��5      $
��Left=�6$   $�� ��6?   $��10,0,0,0q�6G   $	��200��6Y   �� 5      -   5        $��searchButton��5      $��Search��6)   $��5,0,0,0q�6:   6K   �� 5      -   5        $��
EditButton��5      $��Editor��6'   68   �� 5      -   5        $��failedButton��5      $��View Failed��6)   6?   �� 5      -   5        $��CourseDropdown��5      $	��150��6-   $��10,0,0,0q�69   6K   �� 5      -   5        $��GradeDropdown��5      $	��100��6,   $��10,0,0,0q�68   6J   5      �� 5   
   -   5        $��studentList��5      $��0,30,0,0q�6>   ��6&   ��  �� View 5      �� 5      P�5      �� 5      $
��Name��6[    �� Width$	 200��6i    �� DisplayMemberBinding 6)   ��  �� Path$ Studentname�6i   �� 5      $	��Age��6Z   $	 100��6g    6)   �� $ 
Studentage�6g   �� 5      $��Id��6R   $	 100��6^    6)   �� $ Id�6^   �� 5      $��
Coursecode��6Z   $	 100��6n    6)   �� $ 
Coursecode�6n   �� 5      $��Grades��6V   $	 100��6f    6)   �� $ Grades�6f   �� 5      $��
Coursename��6Z   $	 100��6n    6)   �� $ 
Coursename�6n   �� 5      $��Teacher��6W   $	 100��6h    6)   �� $ Teacher�6h   5      5       5!      5"      