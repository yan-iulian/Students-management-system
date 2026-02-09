# Students Management System (Proiect PAW)

Acesta este o aplicație desktop dezvoltată în **C#** folosind **Windows Forms**, creată pentru gestionarea studenților și a notelor acestora.

## Funcționalități Principale

Aplicația permite utilizatorului să efectueze următoarele operațiuni:

*   **Gestionarea Studenților**:
    *   Vizualizarea listei complete de studenți într-un tabel interactiv.
    *   **Adăugare**: Posibilitatea de a introduce noi studenți în baza de date.
    *   **Editare**: Modificarea informațiilor existente pentru un student.
    *   **Pagina Personală**: Vizualizarea detaliată a datelor unui student.
    *   **Coduri de culori**: Studenții sunt evidențiați cu culori diferite în funcție de anul de studiu pentru o identificare vizuală rapidă.

*   **Gestionarea Notelor și Disciplinelor**:
    *   Vizualizarea disciplinelor și notelor asociate fiecărui student.

*   **Funcții Utilitare**:
    *   **Căutare**: Filtrarea rapidă a studenților după nume, prenume sau an de studiu.
    *   **Serializare/Deserializare**: Salvarea și încărcarea datelor studenților într-un fișier binar (`Studenti.dat`) pentru persistența datelor.
    *   **Bază de date**: Proiectul include suport pentru baza de date (SQL Server LocalDB), permițând stocarea permanentă a informațiilor (funcționalitate hibridă cu listă în memorie pentru demonstrație).

## Tehnologii Utilizate

*   **Limbaj**: C#
*   **Framework**: .NET Framework (Windows Forms)
*   **Stocare Date**:
    *   SQL Server (LocalDB) - fișier `.mdf`
    *   Serializare Binară - fișier `.dat`
*   **Mediu de Dezvoltare**: Visual Studio

## Cum se rulează proiectul

1.  Clonează acest repository sau descarcă fișierele.
2.  Deschide fișierul `StudentsManagementSystem.sln` în Visual Studio.
3.  Rulare directă (fără compilare) : Se poate rula direct executabilul:
    * Navighează în folderul: `PROIECT REFACUT PAW/bin/Debug/`
    * Deschide fișierul `PROIECT REFACUT PAW.exe`

## Structura Proiectului

*   `ListaStudentiForm`: Fereastra principală a aplicației.
*   `AddStudentForm` / `EditeazaStudentForm`: Formulare pentru manipularea datelor.
*   `Entitati/`: Clasele de bază (Modelul), ex: `Student.cs`, `Disciplina.cs`.
*   `Baza de date/`: Logica de acces la date.
