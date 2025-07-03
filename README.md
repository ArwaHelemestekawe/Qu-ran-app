# 📖 Qur’an App with Tafsir & Audio Support

An interactive desktop application built with Windows Forms (C# and Guna UI), connected to a MySQL database. This app allows users to explore Surahs and Ayat, view Tafsir, and listen to recitations — all within an intuitive and responsive interface.

---

##  Features

 **User Authentication**  
- Secure login using username and password  
- Sign-up form with name, phone number, and password fields

 **Surah Search & Display**  
- Search Surahs by **number** or **name**  
- Dual-panel layout:
  - Left: Surah info (Ayah count, Makki/Madani classification, Mushaf order)
  - Right: Full Ayat display  
-  **Local audio playback** for each Surah

 **Similar Ayat Search**  
- Search Ayat by a starting word  
- Displays all matching verses with Surah references

 **Tafsir View**  
- Input Surah number → Ayat on the left and corresponding Tafsir on the right

---

##  Tech Stack

| Layer           | Tools Used                         |
|----------------|-------------------------------------|
| **Frontend**    | Windows Forms (.NET Framework), Guna UI |
| **Backend**     | C#                                 |
| **Database**    | MySQL (via phpMyAdmin)             |
| **Data Pipeline** | Python (for JSON to CSV conversion)   |
| **Audio**       | Local audio files                  |

---

##  Data Workflow

- Original Qur’an and Tafsir data in JSON format  
- Preprocessed using Python scripts → converted to CSV  
- Imported into MySQL using phpMyAdmin

---


