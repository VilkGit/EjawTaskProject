# EjawTaskProject
Описания проекта

Версия Unity: 2019.04

Описание скриптов:
- GameData реализует админку проекта, в скрипте находится переменная хранящая время смены
  цвета у объекта. 

/OtherScripts
- ClickOnModel описанна логика нажатия мышкой по объекту, скрипт крепится к MainCamera. 
- JsonNameGeometryObject в скрипте описана структура для json формата, в которой находяться
  имена префабов.
  
 /GeometryObject
 - GeometryObjectCube, GeometryObjectCylinder, GeometryObjectSphere классы наследники от
    GeometryObjectModel, которые вешаються на префабы фигур.
    
/GeometryObject/ObjectClasses 
- ClickColorData хранит данные об цвете и диапазоне кликов по объекту.
- GeometryObjectData хранит данные всех цветов которые доступны для фигуры.
  Реализованы методы для получения цвета.
- GeometryObjectModel описанна логика поведения фигуры.
