   M S B A M L   `   `   `  ����C  ?Humanoid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HumanoidHumanoid  5   	       Humanoid.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Humanoid     5   	   -   5          �Name$  frmMain��5   	    � Title$ Havana��5   	   $	��720��6   $
��1280��6%   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFF6F9FC��6   5       � ColumnDefinitions 5   
   �� 5      $
��230* �6   �� 5      $
��820* �6   �� 5      $
��230* �6   .+�5   
   � $��0��6   $��
20,20,0, 0q�6   $
��Left=�63   $	��Top=�6N   .+�5      �� -   5         ��Name$ 
cbbComPort��5      $��110, 0, 0, 0q�6+   $��Right=�6A   $��30��6]   $	��Top=�6i   $��90��6�   �� 5      -   5         ��Name$ 
btnConnect��5      $��Connect��6)   $��Right=�6;   $��	0,0,105,0q�6W   $	��Top=�6j   $��90��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��30��6�   $��14(�6�   ���	#FF124DCD���	#FF707070$
��Bold"�6  
�������z�5      V� 5       .~�5!      �� �� 5"      �� 5#      	 �� Angle$	 0.029Q�6*   T� 5$      5%      5'      5(      � 5)   
   $��
20,340,0,0q�6   $	��Top=�6#   $
��Left=�6;   .+�5*      �� -   5        
 ��Name$
 chbID1��5*      $��1��6'   $��15��63   $��	65,30,0,0q�6?   $
��Left=�6R   $	��Top=�6m   $��50��6�   6�   �� 5+      -   5        $
 chbID2��5+      $��2��6'   $��15��63   $��	65,60,0,0q�6?   $
��Left=�6R   $	��Top=�6m   $��50��6�   6�   �� 5,      -   5        $
 chbID3��5,      $��3��6'   $��15��63   $��	65,90,0,0q�6?   $
��Left=�6R   $	��Top=�6m   $��50��6�   6�   �� 5-      -   5        $
 chbID4��5-      $��4��6'   $��15��63   $��
65,120,0,0q�6?   $
��Left=�6S   $	��Top=�6n   $��50��6�   6�   �� 5.      -   5        $
 chbID5��5.      $��5��6'   $��15��63   $��
65,150,0,0q�6?   $
��Left=�6S   $	��Top=�6n   $��50��6�   6�   �� 5/      -	   5        $
 chbID6��5/      $��6��6'   $��15��63   $��
65,180,0,0q�6?   $
��Left=�6S   $	��Top=�6n   $��50��6�   6�   �� 51      -
   5        $
 chbID7��51      $��7��6'   $��15��63   $��
65,210,0,0q�6?   $
��Left=�6S   $	��Top=�6n   $��50��6�   6�   �� 52      -   5        $
 chbID8��52      $��8��6'   $��15��63   $��
65,240,0,0q�6?   $
��Left=�6S   $	��Top=�6n   $��50��6�   6�   �� 53      -   5        $
 chbID9��53      $��9��6'   $��15��63   $��
65,270,0,0q�6?   $
��Left=�6S   $	��Top=�6n   $��50��6�   6�   �� 54      -   5        $
 chbID10��54      $��10��6(   $��15��65   $��
65,300,0,0q�6A   $
��Left=�6U   $	��Top=�6p   $��50��6�   6�   �� 56      -   5        $
 chbID11��56      $��11��6(   $��15��65   $��
135,30,0,0q�6A   $
��Left=�6U   $	��Top=�6p   $��50��6�   6�   �� 57      -   5        $
 chbID12��57      $��12��6(   $��15��65   $��
135,60,0,0q�6A   $
��Left=�6U   $	��Top=�6p   $��50��6�   6�   �� 58      -   5        $
 chbID13��58      $��13��6(   $��15��65   $��
135,90,0,0q�6A   $
��Left=�6U   $	��Top=�6p   $��50��6�   6�   �� 59      -   5        $
 chbID14��59      $��14��6(   $��15��65   $��135,120,0,0q�6A   $
��Left=�6V   $	��Top=�6q   $��50��6�   6�   �� 5:      -   5        $
 chbID15��5:      $��15��6(   $��15��65   $��135,150,0,0q�6A   $
��Left=�6V   $	��Top=�6q   $��50��6�   6�   �� 5;      -   5        $
 chbID16��5;      $��16��6(   $��15��65   $��135,180,0,0q�6A   $
��Left=�6V   $	��Top=�6q   $��50��6�   6�   �� 5=      -   5        $
 chbID17��5=      $��17��6(   $��15��65   $��135,210,0,0q�6A   $
��Left=�6V   $	��Top=�6q   $��50��6�   6�   �� 5>      -   5        $
 chbID18��5>      $��18��6(   $��15��65   $��135,240,0,0q�6A   $
��Left=�6V   $	��Top=�6q   $��50��6�   6�   �� 5?      -   5        $
 chbID19��5?      $��19��6(   $��15��65   $��135,270,0,0q�6A   $
��Left=�6V   $	��Top=�6q   $��50��6�   6�   �� 5@      -   5        $
 chbID20��5@      $��20��6(   $��15��65   $��135,300,0,0q�6A   $
��Left=�6V   $	��Top=�6q   $��50��6�   6�   �� 5A      -   5        $
 chbSelectAll��5A      $��
Select All��6-   $��15��6B   $
��Left=�6N   $	��Top=�6i   $��70��6�   6�   5C      � 5D   
   $��20,100,0, 0q�6   $��2��6$   $	��Top=�68   $
��Left=�6P   .+�5F      �� -   5        $ btnGetBattery��5F      $��Get Battery��6,   $��30��6B   $
��Left=�6N   $	��Top=�6i   $��90��6�   $��16(�6�   ���	#FF124DCD$
��Bold"�6�   
�������$��5,0,0,0q�6�   �� 5G      -   5         ��Name$ 
txtPinView��5G      $��30��6*   $��	110,0,0,0q�66    �� TextWrapping$
 Wrap=�6I   $
��Left=�6]   $	��Top=�6x   $��90��6�   ���	#FF3D63D36�   5H      � 5I   
   $��2��6   $��
0,115,20,0q�6   ���	#FF21B14B$��Right=�6J   $	��Top=�6f   $	��205��6~   .+�5K      �� $��Right=�6   $��30��64   $��
0,25,100,0q�6@   $
��Wrap=�6T   $	��Top=�6h   $��95��6�   $
��Time��6�   $��16(�6�    �� TextAlignment$ Center=�6�   $
��Bold"�6�   
�������6�   �� 5L      -   5        $ txbActionTime��5L      $��30��6-   $��	0,25,40,0q�69   $
 Wrap=�6L   $
��1000��6`   $��Right=�6l   $	��Top=�6�   $ 2.273,1.167&�6�   $��50��6�   $��16(�6�    �� TextAlignment$ Center=�6�   �� 5M      $��Right=�6   $��30��64   $��0,25,0,0q�6@   $
��Wrap=�6R   $��ms��6f   $	��Top=�6p   $��30��6�   
�������$
��Bold"�6�   $��16(�6�   �� 5N      $��Action��6   $��Right=�6&   $��20��6B   $��	5,0,150,0q�6N   $
��Wrap=�6a   $	��Top=�6u   $��49��6�   $��10(�6�   $ Center=�6�   $
��Bold"�6�   
�������6�   �� 5P      -   5        $ btnAddAction��5P      $	��Add��6+   $��Right=�69   $��30��6U   $��
5,70,110,0q�6a   $	��Top=�6u   $��90��6�   $ 1,2.333&�6�   ���	#FF124DCD$��14(�6�   $
��Bold"�6  
���������6�   Z� 6!  �� 5Q      -   5        $ 	btnRemove��5Q      $��Remove��6(   $��Right=�69   $��30��6U   $��0,70,5,0q�6a   $	��Top=�6s   $��90��6�   $ 1,2.333&�6�   ���	#FF124DCD$��14(�6�   
�������$
��Bold"�6  ��6�   Z� 6  �� 5R      -   5        $ 	btnUpdate��5R      $��Update��6(   $��Right=�69   $��30��6U   $��5,120,110,5q�6a   $	��Top=�6v   $��90��6�   $ 1,2.333&�6�   ���	#FF124DCD$��14(�6�   $
��Bold"�6�   
���������6�   Z� 6  �� 5S      -   5        $ btnEditTime��5S      $��	Edit Time��6*   $��Right=�6>   $��30��6Z   $��	5,170,5,5q�6f   $	��Top=�6y   $��90��6�   $ 1,2.333&�6�   ���	#FF124DCD$��14(�6�   $
��Bold"�6�   
���������6�   Z� 6  �� 5T      -    5        $ btnClearAction��5T      $��Clear��6-   $
��Left=�6=   $��30��6X   $��	5,170,5,0q�6d   $	��Top=�6w   $��90��6�   
�������$
��Bold"�6�   $��16(�6�   ���	#FF124DCD��6�   Z� 6�   �� 5U      -!   5        $ 	btnInsert��5U      $��Insert��6(   $��Right=�69   $��30��6U   $��	0,120,5,5q�6a   $	��Top=�6t   $��90��6�   $ 1,2.333&�6�   ���	#FF124DCD$��14(�6�   
�������$
��Bold"�6�   ��6  Z� 6  5V      � 5W   
   $��2��6   $��0,340,19.6,0q�6   ���	#FF21B14B$��Right=�6L   $	��205��6h   $��85��6t   $	��Top=�6�   .+�5X      �� -"   5        $ btnRun��5X      $��Run Line��6%   $��Right=�68   $��30��6T   $	��Top=�6`   $��90��6x   ���	#FF124DCD$��16(�6�   $
��Bold"�6�   
�������$��0,5,5,0q�6�   ��6�   Z� 6�   �� 5Y      -#   5        $ btnStop��5Y      $
��Stop��6&   $
��Left=�65   $��
110,50,0,5q�6P   $��90��6d   ���	#FF124DCD$��16(�6�   
�������$
��Bold"�6�   ��6�   Z� �� 5Z      -$   5        $
 chbLoop��5Z      $
��Loop��6(   $��Right=�67   $��30��6S   $��
0,0,110,50q�6_   $��Bottom=�6s   $��90��6�   $��16(�6�   $
��Bold"�6�   
�������
�������6�   �� 5[      -%   5        $ btnRunSingle��5[      $��
Run Single��6+   $��Right=�6@   $��30��6\   $��
0,50,110,5q�6h   $	��Top=�6|   $��90��6�   ���	#FF124DCD$��16(�6�   $
��Bold"�6�   ���	#FFFDFDFD��6�   Z� 6  5\      � 5]   
   $��0��6   $��20,180,0, 0q�6   ���	#FF21B14B$
��Left=�6K   $	��Top=�6f   $	��205��6~   .+�5^      �� -&   5        $ btnSave��5^      $
��Save��6&   $��right=�65   $��
5,75,110,5q�6Q   $��90��6e   ���	#FF124DCD
�������$
��Bold"�6�   $��16(�6�   $��30��6�   ��6�   Z� 6�   �� 5_      -'   5        $ btnOpen��5_      $
��Open��6&   $��right=�65   $��30��6Q   $��90��6]   $��
5,25,110,0q�6h   $	��Top=�6|   ���	#FF124DCD$
��Bold"�6�   
�������$��16(�6�   ��6�   Z� 6�   �� 5`      $��Acton Group��6   $��Right=�6+   $��15��6G   $��0,0,113.8,85.6q�6S   $
��Wrap=�6k   $��Bottom=�6   $��86��6�   $��10(�6�   $ Center=�6�   $
��Bold"�6�   
�������6�   �� 5a      -(   5        $ 	btnSeries��5a      $��Series��6(   $��30��69   $��
110,25,0,0q�6E   $	��Top=�6Y   ���	#FF124DCD$
��Bold"�6�   
�������$��16(�6�   $
��Left=�6�   $��90��6�   ��6�   Z� 6�   �� 5b      -)   5        $ btnClear��5b      $��Clear��6'   $
��Left=�67   $��30��6R   $��
110,75,5,0q�6^   $	��Top=�6r   $��90��6�   
�������$
��Bold"�6�   $��16(�6�   ���	#FF124DCD��6�   Z� 6�   5d      � 5f   
   -*   5         �Name$ grid1��5f      $��60��6   $	��170��6+   $��	20,20,0,0q�67   $
��Left=�6J   $	��Top=�6e   ���	#FF21B14B$��1��6�   .+�5g      �� -+   5         ��Name$ sliPosition1��5g      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD � Maximum$
 1000Q�6�    � Value$	 500Q�6�    �� IsSnapToTickEnabled . 6�   �� 5h      -,   5        $ txbSliderPosition1��5h      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+ �� ElementName$ sliPosition1��6�   �� 5i      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5j      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��30��6a   $
��ID 1��6l   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5m      � 5n   
   --   5        $ grid2��5n      $��60��6   $	��170��6+   $��
200,20,0,0q�67   $
��Left=�6K   $	��Top=�6f   ���	#FF21B14B$��1��6�   .+�5o      �� -.   5        $ sliPosition2��5o      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    � SmallChange$ 1Q�6�    � LargeChange$ 5Q�6�    . 6  �� 5p      -/   5        $ txbSliderPosition2��5p      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition2��6�   �� 5q      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5r      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��30��6a   $
��ID 2��6l   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5u      � 5v   
   -0   5        $ grid3��5v      $��60��6   $	��170��6+   $��
380,20,0,0q�67   $
��Left=�6K   $	��Top=�6f   ���	#FF21B14B$��1��6�   .+�5w      �� -1   5        $ sliPosition3��5w      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5x      -2   5        $ txbSliderPosition3��5x      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition3��6�   �� 5y      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5z      $
��ID 3��6   $��20��6$   $��5,5,0,0q�60   $
��Wrap=�6A   $	��Top=�6U   $��30��6m   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5}      � 5~   
   -3   5        $ grid4��5~      $��60��6   $	��170��6+   $��
560,20,0,0q�67   $
��Left=�6K   $	��Top=�6f   ���	#FF21B14B$��1��6�   .+�5      �� -4   5        $ sliPosition4��5      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -5   5        $ txbSliderPosition4��5�      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition4��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $
��ID 4��6   $��20��6$   $��5,5,0,0q�60   $
��Wrap=�6A   $	��Top=�6U   $��30��6m   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -6   5        $ grid5��5�      $��60��6   $	��170��6+   $��
20,100,0,0q�67   $
��Left=�6K   $	��Top=�6f   ���	#FF21B14B$��1��6�   .+�5�      �� -7   5        $ sliPosition5��5�      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -8   5        $ txbSliderPosition5��5�      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition5��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��30��6a   $
��ID 5��6l   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -9   5        $ grid6��5�      $��60��6   $	��170��6+   $��200,100,0,0q�67   $
��Left=�6L   $	��Top=�6g   ���	#FF21B14B$��1��6�   .+�5�      �� -:   5        $ sliPosition6��5�      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -;   5        $ txbSliderPosition6��5�      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition6��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��30��6a   $
��ID 6��6l   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -<   5        $ grid7��5�      $��60��6   $	��170��6+   $��380,100,0,0q�67   $
��Left=�6L   $	��Top=�6g   ���	#FF21B14B$��1��6�   .+�5�      �� -=   5        $ sliPosition7��5�      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      ->   5        $ txbSliderPosition7��5�      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition7��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $
��ID 7��6   $��20��6$   $��5,5,0,0q�60   $
��Wrap=�6A   $	��Top=�6U   $��30��6m   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -?   5        $ grid8��5�      $��60��6   $	��170��6+   $��560,100,0,0q�67   $
��Left=�6L   $	��Top=�6g   ���	#FF21B14B$��1��6�   .+�5�      �� -@   5        $ sliPosition8��5�      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -A   5        $ txbSliderPosition8��5�      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition8��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $
��ID 8��6   $��20��6$   $��5,5,0,0q�60   $
��Wrap=�6A   $	��Top=�6U   $��30��6m   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -B   5        $ grid9��5�      $��60��6   $	��170��6+   $��
20,180,0,0q�67   $
��Left=�6K   $	��Top=�6f   ���	#FF21B14B$��1��6�   .+�5�      �� -C   5        $ sliPosition9��5�      $
��Left=�6+   $��20��6F   $��45,5,0,0q�6R   $	��Top=�6d   $	��120��6|   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -D   5        $ txbSliderPosition9��5�      $��60��62   $��
105,35,0,0q�6=   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6Q   �� *Value+$ sliPosition9��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��30��6a   $
��ID 9��6l   $��14(�6x   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -E   5        $ grid10��5�      $��60��6    $	��170��6,   $��200,180,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -F   5        $ sliPosition10��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -G   5        $ txbSliderPosition10��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition10��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��37��6a   $��ID 10��6l   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -H   5        $ grid11��5�      $��60��6    $	��170��6,   $��380,180,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -I   5        $ sliPosition11��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -J   5        $ txbSliderPosition11��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition11��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��ID 11��6   $��5,5,0,35q�6%   $
��Wrap=�67   $��36��6K   $��14(�6V   $ Center=�6d   $
��Bold"�6{   $
��Left=�6�   
�������6�   5�      � 5�   
   -K   5        $ grid12��5�      $��60��6    $	��170��6,   $��560,180,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -L   5        $ sliPosition12��5�      $
��Left=�6,   $��20��6G   $��	45,0,0,35q�6S   $��Bottom=�6f   $	��120��6�   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -M   5        $ txbSliderPosition12��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition12��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��ID 12��6   $��20��6%   $��5,5,0,0q�61   $
��Wrap=�6B   $	��Top=�6V   $��36��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -N   5        $ grid13��5�      $��60��6    $	��170��6,   $��
20,260,0,0q�68   $
��Left=�6L   $	��Top=�6g   ���	#FF21B14B$��1��6�   .+�5�      �� -O   5        $ sliPosition13��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -P   5        $ txbSliderPosition13��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition13��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��36��6a   $��ID 13��6l   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -Q   5        $ grid14��5�      $��60��6    $	��170��6,   $��200,260,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -R   5        $ sliPosition14��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -S   5        $ txbSliderPosition14��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition14��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��37��6a   $��ID 14��6l   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -T   5        $ grid15��5�      $��60��6    $	��170��6,   $��380,260,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -U   5        $ sliPosition15��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -V   5        $ txbSliderPosition15��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition15��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��ID 15��6   $��20��6%   $��5,5,0,0q�61   $
��Wrap=�6B   $	��Top=�6V   $��36��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -W   5        $ grid16��5�      $��60��6    $	��170��6,   $��560,260,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -X   5        $ sliPosition16��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -Y   5        $ txbSliderPosition16��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition16��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��ID 16��6   $��20��6%   $��5,5,0,0q�61   $
��Wrap=�6B   $	��Top=�6V   $��36��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -Z   5        $ grid17��5�      $��60��6    $	��170��6,   $��
20,340,0,0q�68   $
��Left=�6L   $	��Top=�6g   ���	#FF21B14B$��1��6�   .+�5�      �� -[   5        $ sliPosition17��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -\   5        $ txbSliderPosition17��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition17��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��36��6a   $��ID 17��6l   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -]   5        $ grid18��5�      $��60��6    $	��170��6,   $��200,340,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -^   5        $ sliPosition18��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -_   5        $ txbSliderPosition18��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition18��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��20��6   $��5,5,0,0q�6$   $
��Wrap=�65   $	��Top=�6I   $��37��6a   $��ID 18��6l   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -`   5        $ grid19��5�      $��60��6    $	��170��6,   $��380,340,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -a   5        $ sliPosition19��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5�      -b   5        $ txbSliderPosition19��5�      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition19��6�   �� 5�      $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5�      $��ID 19��6   $��20��6%   $��5,5,0,0q�61   $
��Wrap=�6B   $	��Top=�6V   $��36��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5�      � 5�   
   -c   5        $ grid20��5�      $��60��6    $	��170��6,   $��560,340,0,0q�68   $
��Left=�6M   $	��Top=�6h   ���	#FF21B14B$��1��6�   .+�5�      �� -d   5        $ sliPosition20��5�      $
��Left=�6,   $��20��6G   $��45,5,0,0q�6S   $	��Top=�6e   $	��120��6}   ���	#FF124DCD$
 1000Q�6�   $	 500Q�6�    . 6�   �� 5      -e   5        $ txbSliderPosition20��5      $��60��63   $��
105,35,0,0q�6>   $��20��6�   $	��Top=�6�   $
��Left=�6�   ��6R   �� *Value+$ sliPosition20��6�   �� 5     $��20��6   $��	45,35,0,0q�6$   $
��Wrap=�67   $	��Top=�6K   $��30��6c   $	��Pos��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   �� 5     $��ID 20��6   $��20��6%   $��5,5,0,0q�61   $
��Wrap=�6B   $	��Top=�6V   $��36��6n   $��14(�6y   $ Center=�6�   $
��Bold"�6�   $
��Left=�6�   
�������6�   5     �� 5  
   -f   5         ��Name$ 	livAction��5  #   $��1��6   $
��Left=�6^   $	��240��6y   $��20.2,430,0,0q�6�   $	��Top=�6�   $
��1000��6�   $��2��6�   ���	#FFB9F4BC���	#FF6974E4��66   �� *TrackCollection+ �� View 5     �� 5     .P�5     �� $��Index��6%    �� Width$ 50��64    �� DisplayMemberBinding 6?   �� *
IndexPro+�� 5     $��	Time (ms)��6%   $ 60��68    6C   �� *	TimePro+�� 5     $��Action��6%   $	 890��65    6A   �� *	ActionPro+5     5     � 5  
   $��2��6   ���	#FF21B14B$��	0,20,20,0q�66   $��Right=�6I   $	��Top=�6e   $��75��6}   $	��205��6�   .+�5     �� -g   5        $ btnOff��5     $��	Motor Off��6%   $��Right=�69   $��30��6U   $��	5,5,110,5q�6a   ���	#FF124DCD$��14(�6�   $	��Top=�6�   $��90��6�   $
��Bold"�6�   
���������6�   Z� 6�   �� 5     -h   5        $ btnRead��5     $��
Read Angle��6&   $��Right=�6;   $��30��6W   $	��Top=�6c   $��90��6{   $��0,5,6,0q�6�   ���	#FF124DCD$��14(�6�   $
��Bold"�6�   
���������6�   Z� 6�   �� 5     -i   5        $ btnUpdateAngle��5     $��Update Angle��6-   $��Right=�6D   $��30��6`   $	��Top=�6l   $��90��6�   $��0,40,5,0q�6�   ���	#FF124DCD$
��Bold"�6�   
���������6�   Z� 6�   5      5"     5#     