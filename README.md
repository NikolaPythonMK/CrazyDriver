# CrazyDriver
Windows Forms Project by: Nikola Nikolovski and Jovan Stojcev

## 1.Опис на апликацијата<br><br>
Цел на апликацијата е да обезбеди комплетно задоволство кај играчот. Играчот контролира автомобил со левата и десната стрелка од тастатурата и треба да избегнува други автомобили кои доаѓаат од спротивна насока.<br>
Постепено, брзината на автомобилите од спротивна насока ќе им се зголемува и се повеќе автомобили ќе доаѓаат од спротивната насока.
Во играта има Score кој се зголемува при играњето.<br>

Играчот може да купува автомобили со парите што ги освојувал со играње. Автомобилите, парите и High Score на корисникот се зачувани.

## 2. Упатство на користење<br><br>
### 2.1 Автентикација<br><br>
![login](https://user-images.githubusercontent.com/76405057/176419256-dd1645b9-2fa3-4d04-8d6f-897421e21bd9.png)<br>
При стартување на апликацијата (слика 1) играчот треба прво да се логира за да продолжи.<br>
Доколку играчот нема направено корисничка сметка или сака да направи нова сметка, треба да притисне на линкот here.<br>
Откога корисникот ке притисне на линкот, ке се отвори нов прозорец (слика 2), каде што ке треба да ги внесе потребните податоци.<br><br>
![reg](https://user-images.githubusercontent.com/76405057/176420510-a022bae9-a018-4db9-8e23-e84afa5a1fae.png)<br><br>

### <br>2.2 Почетно мени<br>

Откога корисникот ке се логира, ке биде пренасочен кон почетното мени. (слика 3)<br>

![main](https://user-images.githubusercontent.com/76405057/176422307-63ed17e2-3327-4d05-b697-32d9feafb8d4.png)

Одтука корисникот може да започне со игра (Play), да ја посети продавницата за автомобили (Shop) или да ги подеси контролите (Settings).<br>
Играчот има избор на автомобили од тие што ги има купено.
при клик на копчето Next ќе се прикаже друг автомобил. На почеток, на играчот му е дадена почетна плава кола која не е многу брза. <br>
Прикажани се информациите за корисникот: Username, High Score и колку пари има.<br>
Откако играчот ќе сака да престане со играње, пред да се угаси ке треба да кликне на копчето Sava Data, во спротивно нема да се зачуваат новите податоци.<br>

### <br>2.3 Play


![gameplay2](https://user-images.githubusercontent.com/76405057/176428947-f2d3dd89-c069-405e-bd9e-5f2fdf204300.png)

Целта на играта е играчот да собере колку што може поени без да се судри со некој од автомобилите кои доаѓаат од спротивната насока.<br>
Играчот го контролира автомобилот со помош на левата и десната стрелка од тастатурата<br>
брзината на автомобилите од спротивната насока постепено се зголемува и се повеќе автомобили ке доаѓаат од таа насока.<br>
Во горениот лев агол е прикажан моменталниот score на играчот како и најдобриот score кој го има постигнато, а во горниот десен агол има копче за пауза.<br>
Доколку играчот се удри со некоја од автомобилите ќе се отвори прозорец (слика 4) каде што доколку играчот има доволно пари, со стискање на копчето YES ќе може да плати за да продолжи од таму каде што се удрил. Доколку притисне на NO, ќе се врати во почетното мени со парите што ги освоил.<br>

![continue](https://user-images.githubusercontent.com/76405057/176475380-39f12754-f380-41c5-8d29-871e529d1e2b.png)<br>

### <br>2.4 Shop

Во продавницата за автомобили играчот може да купи автомобил со парите освоени од играње. Поскапите автомобили се побрзи.<br>
купените автомобили на корисникот се зачувуваат, кога играчот повторно ќе ја отвори апликацијата ќе може да бира со кој автомобил сака да игра. 

![shop](https://user-images.githubusercontent.com/76405057/176476806-caa03f9f-7bc5-4a6a-9238-d200f5b2ae7f.png)

### <br>2.5 Settings

Во Settings, играчот може да ги намести контролите да бидат на A и D, и има опција да ги запре музиките од главното мени и од играта.

![settings](https://user-images.githubusercontent.com/76405057/176479901-4eab5755-d4a2-466e-bc95-294f0bf862e4.png)

## <br>3. Претставување на проблемот

Главните податоци и функции за играта се чуваат во класа public class UserData 


