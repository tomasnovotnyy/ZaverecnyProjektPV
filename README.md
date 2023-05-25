# **ZaverecnyProjektPV**
+ Tato aplikace slouží pro:
  - Vytvoření svého vlastního stromu, který je poté reprezentován jak v slovně 
popsané podobě, tak i v lidsky čitelné podobě.
  - Nalezení nejkratší cesty z vrcholu 𝑠 (startovního vrcholu) do ostatních vrcholů grafu pomocí Dijkstrova algoritmu.
  - Kódování a dekódování binárního kódu, reversního kódu a Caesarovy šifry.<br/>
+ Při spuštění si uživatel může zvolit ze tří různých možností:

  | Button | Název |
  |:---|:---:|
  |     1.| Popis aplikace |
  |     2.| Start |
  |     3.| Tutorial |
+ Pro zavření aplikace může uživatel použít křížek v pravém horním rohu nebo tlačítko **'Exit'**.<br/>
# *Popis aplikace*
> Toto tlačítko slouží pro rychlé a jednoduché pochopení cíle mé závěrečné práce z předmětu PV. Zároveň je zde popsáno co vše je v aplikaci možné dělat.
# *Start*
> Tlačítko start slouží pro otevření nové formy s nabídkou tří nových možností:
>  | Button | Název |
>  |:---|:---:|
>  |     1.| Vytvoření grafu |
>  |     2.| Dijkstrův algoritmus |
>  |     3.| Kódování |
>  
>  # *Vytvoření grafu*
>  Po kliknutí na tlačítko 'Vytvoření grafu' se uživateli zobrazí okna pro:
>  - vytvoření kořene stomu
>  - vybrání počtu uzlů ve stromu
>  - zadávání hodnot jednotlivých uzlů
>  
>  Pokud uživatel zadal vše správně, tak se zobrazí:
>  - počet vrcholů v grafu
>  - výsledný graf v lidsky čitelné podobě
>  - otázka, zda si uživatel přeje graf uložit do textového souboru
>  - seřazování čísel:
>     - InOrder
>     - PreOrder
>     - PostOrder
>     - HeapSort
>     - QuickSort
>  # *Dijkstrův algoritmus*
>  Po kliknutí na tlačítko 'Dijkstrův algoritmus' se uživateli zobrazí nová forma, kde je popsáno co to vlastně Dijkstrův algoritmus je a pomocí jednoduchého příkladu s obrázkem si uživatel bude moci po kliknutí na tlačítko 'Dijkstrův algoritmus' vyzkoušet jak takový Dijkstrův algoritmus funguje. Po kliknutí na toto tlačíto se zobrazí okno, kde uživatel zadá počáteční vrchol -> poté se zobrazí vzdálenost od počátku pro jednotlivé vrcholy v grafu.
>  # *Kódování*
>  Po kliknutí na tlačítko 'Kódování' se uživateli zobrazí nová forma s dalšími třemi tlačítky:
>  | Button | Název |
>  |:---|:---:|
>  |     1.| Binární |
>  |     2.| Reversní |
>  |     3.| Caesarova šifra |
>  - # *Binární kódování*
>    Pro použití uživatel zadá do textového pole v prvním řádku řetězec, který chce zakódovat a následně klikne na tlačítko 'Encode'. V pravém textovém poli se uživateli zobrazí zakódovaný řetězec v podobě nul a jedniček (binární kód).<br/><br/>
> Pro dekódování uživatel zadá do textového pole v druhém řádku binární řetězec, který chce dekódovat a následně klikne na tlačítko 'Decode'. V pravém textovém poli se uživateli zobrazí dekódovaný řetězec.<br/><br/>
> Uživatel má také možnost vyčistit všechna textová pole pomocí tlačítka 'Clear'.
>  - # *Reversní kódování*
>     Pro použití uživatel zadá do textového pole v prvním řádku řetězec, který chce zakódovat a následně klikne na tlačítko 'Encode'. V pravém textovém poli se uživateli zobrazí zakódovaný řetězec, kde je každý znak v opačné/reversní pozici než v jaké byl původně napsaný.<br/><br/>
> Pro dekódování uživatel zadá do textového pole v druhém řádku řetězec, který chce dekódovat a následně klikne na tlačítko 'Decode'. V pravém textovém poli se uživateli zobrazí dekódovaný řetězec.<br/><br/>
> Uživatel má také možnost vyčistit všechna textová pole pomocí tlačítka 'Clear'.
>  - # *Caesarova šifra*
>     Princip Caesarovy šifry je založen na tom, že všechna písmena zprávy jsou během šifrování zaměněna za písmeno, které se abecedně nachází o pevně určený počet míst dále (tj. posun je pevně zvolen). V našem případě je každé písmeno posunuto o tři místa v abecedě, tedy 'a' --> 'd', 'b' --> 'e' atd.<br/><br/>
> Pro použití uživatel zadá do textového pole v prvním řádku řetězec, který chce zakódovat a následně klikne na tlačítko 'Encode'. V pravém textovém poli se uživateli zobrazí zakódovaný řetězec, kde je každý znak posunut o tři místa v abecedě.<br/><br/>
> Pro dekódování uživatel zadá do textového pole v druhém řádku řetězec, který chce dekódovat a následně klikne na tlačítko 'Decode'. V pravém textovém poli se uživateli zobrazí dekódovaný řetězec.
> 
>     Uživatel má také možnost vyčistit všechna textová pole pomocí tlačítka 'Clear'.
# *Tutorial*
> Pomocí tohoto tlačítka se uživatel naučí jak správně zadávat a pracovat s jednotlivými sekcemi. Po kliknutí se zobrazí další tři tlačítka:
>  | Button | Název |
>  |:---|:---:|
>  |     1.| Vytvoření grafu |
>  |     2.| Dijkstrův algoritmus |
>  |     3.| Kódování |
>  
>  Po kliknutí na jedno z tlačítek se uživateli zobrazí tutorial pro danou sekci.
>  
>  # *Vytvoření grafu*
>  Pro vytvoření stromu/grafu musí uživatel udělat následující kroky:
> - Nejdříve musí uživatel zadat kořen stromu od kterého se budou odvíjet všechny následující kroky. 
> - Po úspěšném zadání se uživateli na obrazovce ukáže jeho zadaná hodnota kořene stromu, aby se ujistil, že zadal správné číslo.
> - Následně si uživatel vybere počet následujících uzlů, které chce zadat. Podle počtu uzlů bude uživatel zadávat hodnoty těchto uzlů, přičemž by neměl opakovat stejná čísla.
> 
> Pokud udělá uživatel vše správně, tak se mu na obrazovce zobrazí následující informace:
> 1. Počet vrcholů v grafu
> 2. Výsledný graf v lidsky čitelné podobě
> 3. Seřazování čísel<br/>
	a) InOrder<br/>
	b) PreOrder<br/>
	c) PostOrder<br/>
	d) HeapSort<br/>
	e) QuickSort<br/><br/>
> # *Dijkstrův algoritmus*
> Dijkstrův algoritmus je algoritmus sloužící k nalezení nejkratší cesty v grafu --> řeší nejkratší cestu z vrcholu 𝑠 (startovního vrcholu) do ostatních vrcholů grafu.<br/><br/>
> V tomto programu používám pro ukázku graf se 4 vrcholy, kde jsou vrcholy označeny čísly 0, 1, 2 a 3, a hranou spojující vrcholy 0 a 1 s váhou 2, hranou spojující vrcholy 1 a 2 s váhou 3 a hranou spojující vrcholy 2 a 3 s váhou 4.<br/><br/>
> Uživatel si po kliknutí na tlačítko 'Dijkstrův algoritmus' vybere počáteční vrchol a následně se mu ukáže vzdálenost od počátku.<br/><br/>
> # *Kódování*
> - # *Binární kódování*
> 	Binární kód je v informatice způsob uložení informace v počítači definovaný jako konečný počet bitů, z nichž každý může nabývat právě jednu ze dvou hodnot (obvykle označených 0 nebo 1).<br/><br/>
> Pro použití uživatel zadá do textového pole v prvním řádku řetězec, který chce zakódovat a následně klikne na tlačítko 'Encode'. V pravém textovém poli se uživateli zobrazí zakódovaný řetězec v podobě nul a jedniček (binární kód).<br/><br/>
> Pro dekódování uživatel zadá do textového pole v druhém řádku binární řetězec, který chce dekódovat a následně klikne na tlačítko 'Decode'. V pravém textovém poli se uživateli zobrazí dekódovaný řetězec.<br/><br/>
> Uživatel má také možnost vyčistit všechna textová pole pomocí tlačítka 'Clear'.<br/><br/>
> V případě chyby se uživateli zobrazí hláška s upozorněním a popisem co je špatně.<br/><br/>
> - # *Reversní kódování*
> 	Pro použití uživatel zadá do textového pole v prvním řádku řetězec, který chce zakódovat a následně klikne na tlačítko 'Encode'. V pravém textovém poli se uživateli zobrazí zakódovaný řetězec, kde je každý znak v opačné/reversní pozici než v jaké byl původně napsaný.<br/><br/>
> Pro dekódování uživatel zadá do textového pole v druhém řádku řetězec, který chce dekódovat a následně klikne na tlačítko 'Decode'. V pravém textovém poli se uživateli zobrazí dekódovaný řetězec.<br/><br/>
> Uživatel má také možnost vyčistit všechna textová pole pomocí tlačítka 'Clear'.<br/><br/>
> V případě chyby se uživateli zobrazí hláška s upozorněním a popisem co je špatně.<br/><br/>
> - # *Caesarova šifra*
> 	Princip Caesarovy šifry je založen na tom, že všechna písmena zprávy jsou během šifrování zaměněna za písmeno, které se abecedně nachází o pevně určený počet míst dále (tj. posun je pevně zvolen). V našem případě je každé písmeno posunuto o tři místa v abecedě, tedy 'a' --> 'd', 'b' --> 'e' atd.<br/><br/>
> Pro použití uživatel zadá do textového pole v prvním řádku řetězec, který chce zakódovat a následně klikne na tlačítko 'Encode'. V pravém textovém poli se uživateli zobrazí zakódovaný řetězec, kde je každý znak posunut o tři místa v abecedě.<br/><br/>
> Pro dekódování uživatel zadá do textového pole v druhém řádku řetězec, který chce dekódovat a následně klikne na tlačítko 'Decode'. V pravém textovém poli se uživateli zobrazí dekódovaný řetězec.<br/><br/>
> Uživatel má také možnost vyčistit všechna textová pole pomocí tlačítka 'Clear'.<br/><br/>
> V případě chyby se uživateli zobrazí hláška s upozorněním a popisem co je špatně.<br/><br/>
# *Hardware & Software*
<details>
<summary>Hardware</summary>
Název zařízení: MSI<br/>
Procesor: 11th Gen Intel(R) Core(TM) i7-11800H @ 2.30GHz 2.30 GHz<br/>
Nainstalovaná paměť RAM: 16,0 GB (použitelné: 15,7 GB)<br/>
Typ systému: 64bitový operační systém, procesor pro platformu x64<br/>
Edice: Windows 11 Home Single Language<br/>
Verze: 22H2<br/>
</details>

<details>
<summary>Software</summary>
IntelliJ IDEA 2022.1 (Community Edition)<br/>
Build #IC-221.5080.210, built on April 12, 2022<br/>
Runtime version: 11.0.14.1+1-b2043.25 amd64<br/>
VM: OpenJDK 64-Bit Server VM by JetBrains s.r.o.<br/>
Copyright © 2000–2022 JetBrains s.r.o.<br/>
</details>
