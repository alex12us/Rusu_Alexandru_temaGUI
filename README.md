OpenTKLab11- OpenTK_winforms_z03
Iluminarea,texturarea transparentă,mișcarea obiectelor

Laboratorul 11
  • Care este rolul comenzilor GL.Push() și GL. Pop()? De ce este
necesară utilizarea lor?

În OpenGL, GL.PushMatrix() are rolul de a salva matricea curentă înaintea de a  suferi anumite modificări precum rotația și translatarea,
  iar GL.PopMatrix() are rolul de a restuara matricea anterioară salvată de pe stivă și revine la ceea ce a fost înainte. Sunt necesare funcțile GL.Pushmatrix() și GL.PopMatrix() pentru a preveni  distiorsionarea obiectului respectiv.

• Explicați efectul rulării metodelor GL.Rotate(), GL.Translate()
și GL.Scale(). Furnizați câte un exemplu comentat!
  GL.Translate()-are rolul de a poziționa obiecte pe coordonatele x,y,z
  exemplu:GL.Translate(10,20,30);
  GL.Rotate()-are rolul de a roti un obiect la un anumit unghi pe coordonatele x,y,z
  GL.Rotate(angle_X,1.0f,0.0f,0.0f);
  GL.Scale()-are rolul de a mări sau  de a micșora obiectul prin intermediul axelor x,y,z.
  GL.Scale(2,0,0);
• Câte nivele de manipulări ierarhice (folosindu-se
GL.Push()/GL.Pop()) suportă o scenă OpenGL?
    GL.Push()/GL.Pop() suportă pe scena OpenGL doar 32 de nivele de manipulări ierarhice (matrice) stocate pe stivă.
