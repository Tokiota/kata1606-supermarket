# kata1606-supermarket
<p style="text-align:center; float: right;" align="center">
  <img align="center" src="http://static.panoramio.com/photos/large/21182144.jpg" style="text-align:center; float: right;"/>
</p>

####ToKata03: Tarificación en Supermercado

Ésta Kata surgió de las discusiones que se han ido manteniendo en los encuentros de la DFW Practioners. El alcance del problema es algo aparentemente simple: poner precio a productos de supermercados. 
Algunas cosas en los supermercados tienen precios simples: ‘Ésta lata de judías cuesta $0.65’. Otras tienen precios más complejos. Por ejemplo:
  
  •	3 por 1 dólar (Entonces, ¿cuál es el precio si compro 4, o 5?)
  •	$1.99/libra*  (Así que, ¿cuánto cuestan 4 onzas*?)
  •	Compra 2, llévate  1 gratis (¿Así pues, el 3er ítem tiene un precio?)
  
Ésta kata no implica ‘picar código’. El ejercicio trata de experimentar varios modelos para representar moneda y precios que sean suficientemente flexibles como para lidiar con estos (y otros) esquemas de tarificación, y que al mismo tiempo sean usables de forma genérica (al confirmar la compra, para gestión de disponibilidad, pedidos entrantes, y más).
  
Invertid tiempo considerando cuestiones tales cómo:
  
  *	Existe la  fracción de unidad monetaria? (decimales)
  *	¿Cuándo (si procede) tienen lugar los  redondeos?
  *	¿Cómo mantendrías los datos de auditoria referentes a las decisiones  de tarificado (y lo necesitas)?
  *	¿Son los costes y los precios la misma clase de cosas?
  *	Si un estante de 100 latas se tarifica usando “compra 2, llévate 1 gratis”, ¿cómo afecta eso a la valoración del stock?
  
Ésta kata es ideal para reflexionar, pero sed precavidos. Algunos de los problemas son más sutiles de lo que aparentan a simple vista. Os sugerimos que meditéis sobre ellos a lo largo de las siguientes semanas hasta que deis con las mejores soluciones.

####Objetivo
  
El objetivo de esta kata es practicar un estilo ‘más suave’ de modelizado. Buscad tantas formas de resolver los problemas como os sea posible.
Considerar las carencias y exigencias de cada una  de ellas.
¿Qué técnicas son las mejores para explorar esos modelos? ¿Y para guardarlos? ¿Cómo puedes aplicar las reglas de validación de los modelos?
  
  * 1 libra = 453,59237 gramos
  * 1 onza = 28,3495231 gramos

####Fecha
La tendríamos que tener lista para el último martex del mes, en este caso el 28/06/2016.

####¡Donde la cuelgo!
Aquí mismo, cada uno se crea una branch y listo.

####Source
http://codekata.com/kata/kata01-supermarket-pricing/
