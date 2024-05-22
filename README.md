# ZaverecnyProjektBasicLampart
Třídy projektu a jejich funkcionalita:
LogikaPoSpustění:
třída má jedinou metodu "Zahajit", která se while cyklem stará o celkový běh aplikace a na základě uživatelského inputu za pomocí switche vyvolává metody z třídy DatabazePojistencu.
DatabazePojistencu:
třída vytváří kolekci pro ukládání jednotlivých Pojistenců z třídy Pojistenec.
Metoda PridejPojistence, vytváří konstruktor třídy Pojistenec a za pomocí třídy DataHandler získává jeho povinné atributy (jméno, příjmení, věk, tel.číslo). Metoda poté uloží pojištěnce ko kolekce pojištěnců.
Metoda VyhledejKonkrétního pojištěnce, metoda za pomocí třídy DataHandler získá přesné jméno a příjmení konkrétního pojištěnce a na základě shody v kolekci nám vrátí textovou reprezantaci pojištěncě.
V případě neshody, nám metoda nabídne vyhledání opakovat a nebo zrušit.
Metoda ZobrazVsechnyPojistence, metoda za pomocí foreach cyklu proiteruje kolekci a vrátí textovou reprezentaci všech pojištěnců uložených v kolekci. V případě prázdné kolekce nás na tuto zkutečnost metoda upozorní.
DataHandler:
Třídá získává data na základě uživatelských vstupů.
Metoda ZiskejVsechnyData, metoda si postupně vyžádá zadání povinných údajů, jména, příjmení, věku a tel.čísla. Tyto vstupy ošetří třída Validator. Metoda následně vrátí nového pojištěnce.
Metoda ZiskejHledaneJmeno, metoda získá konkrétní jméno pro vyhledávání na základě uživatelského vstupu, tento vstup ošetří třída Validator.
Metoda ZiskejHledanePrijmeni, metoda získá konkrétní příjmení pro vyhledávání na základě uživatelského vstupu, tento vstup ošetří třída Validator.
Validator:
Obsahuje metody: ValidujJmeno, ValidujPrijmeni, ValidujVek, ValidujTelCislo, které na základě přednastavených podmínek hlídají uživatelské vstupy.
Pojistenec:
Třída reprezentující pojištěnce ukládaného do kolekce. Obsahuje povinné atributy jméno, příjmení, věk a tel.číslo.
třída Menu, je pouze jakési "grafické UI" pro zkrášlení konzolové aplikace.
