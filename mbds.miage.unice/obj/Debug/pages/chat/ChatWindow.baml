   M S B A M L   `   `   `  ����K  Gmbds.miage.unice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:mbds.miage.unice.pages.chatmbds.miage.unice.pages.chat  5   	   ,    &mbds.miage.unice.pages.chat.ChatWindow   5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:mbds.miage.unice.pages.chat     5   	   *  $MaterialDesignThemes.Wpf.ThemeAssist    Theme$  Light=�5	   	    � Icon$ ../../images/wechat.png��5
   	    � WindowStyle$ SingleBorderWindow=�5   	   $	��500��5   	   $	��800��6    � 	Resources 5         MaterialDesignListBox   MaterialDesignListBox �� BasedOn �� 
TargetType �� Property �� Value  	User-List,  &MaterialDesignThemes.Wpf.ListBoxAssist   IsToggle	 �� Path
 �� RelativeSource �� Mode �� AncestorType � ColumnDefinitions � RowDefinitions �� RadiusX �� RadiusY �� ImageSource �� Mode �� Padding��%�  &	        7  '�� O     &	 5    �� 5   
   8   " ��6`   .�5      ��  � ��
 �   �6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 0q�6'   �� 5       � ��$ 0q�6(   �� 5       � ��
 �����6,   �� 5       � ��$ 0 0 0 1q�60   �� 5       �@ Theme$ Light=�6A   5      �� 5   
   .R�5      �  . $��0 5 0 5q�5      ��5      �� $	 ActualWidth�
 �� $ FindAncestor=�$ ListBoxL���5      �� $	 ActualHeight�
 �� $ FindAncestor=�$ DataTemplateL� 5      �� 5      61   �� 5       61    5"      �� 5#      6.   �� 5$      6.   .+�5&      �� $��40��6    $��40��6,   $ 3��67   $ 3��6C   ��5'      �� 5(      profile_image�� 6@   �� $	 SrcImage�$ OneWay=�5*      �� 5+      $��1��6    $ 15 0 0 0q�6W   ��60   �� $
	 Name�$ OneWay=�6W   5,      5-      5.      .��5/      �  50   
   �� 51      $	��200��6   $	��200��6.   6?   �� 52      $��3* �6   6,    54   
   �� 55      $��50��6   $��50��6+   6<   �� 56      $	��11* �6   6+   �� 57      $	��120��6   $	��120��6,   $	��120 �6<   6K   �� 58      $��50��6   $��50��6+   6<   .+�5:   
   �� $��1��5<      $��3��5=      $
��Auto=�5>      $��Disabled=�5?      ��5;      �� $	 ActualWidth�
 �� $ FindAncestor=�$ ColumnDefinitionL�.��5@      �� -   5        $��ChatList��5B      #���  5A      $��0q�5C      ���#E7E6E4$��0q�5E      #��[ 5G      ��5F      �� $	 ActualWidth�
 �� $ FindAncestor=�$ ColumnDefinitionL���5H      �� *
UserList+$ OneWay=�5J      �� 5K   
   -   5         ��Name$
 Sent��5M      $��	10 3 10 3q�5L      $��0q�5N       �� TextWrapping$
 Wrap=�5O      $��1��5P      $��2��5Q      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5R      $	��Top=�5S      6.   �� 5T   
   ���#F6F6F2���#f6f6f2$��70��5W      $��70��5X      $��30��5Y      $��30��5Z      $��1��5[      $��3��5\      $��Center=�5]      $��Right=�5^      $
��35 0q�5_      $
��Sent��5`       # MaterialDesignRaisedLightButton#���  5a      �� 5b   
   $��20��6   $��20��6   $��Right=�6(   $��0 0 10 0q�6D   $��0q�6V   
�������$��0q�6z   #���  6�    K� ZIndex$	 100��6�   .��5c      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Plus=�6&    �� BitmapScalingMode$ HighQuality=�62   $��Center=�6`   $��Center=�6{   5d      �� 5f   
   
�������$��0q�5h      ���#E7E6E45i      �� 5k   
   $��1��6   
�������$��1,0,0,0q�69   ���#F6F6F26S   �� 5l   
   $��1��6   $��1��6   $��1q�6.   
����������#F6F6F26Z   �� 5m   
   $��1��6   $��3��6   $��0,0,0,0q�6/   
�������6I   �� 5n   
   $��2��6   $��1��6   $��1,0,0,0q�6.   
�������6H   �� 5o   
   $��3��6   $��1��6   $��1,0,0,0q�6.   
�������6H   5p      5q      