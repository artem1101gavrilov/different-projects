
function love.load()
	love.window.setMode(800, 800)

	width = love.graphics.getWidth() - 30			--функция возвращает длину окна на данный момент
	height = love.graphics.getHeight() - 30			--тоже самое но с высотой

	mainFont = love.graphics.newFont(50);
	love.graphics.setFont(mainFont);

end
 
function love.update(dt)
	
end
 
function love.keypressed(key, unicode)
	
end

function love.keyreleased(key, unicode)
end 

function love.mousepressed(x, y, button, istouch)
   
end

function love.mousereleased(x, y, button, istouch)
  
end

function love.draw()
	love.graphics.setColor(150, 150, 150)
	love.graphics.setLineWidth( 3 )
	for i = 0, 100 do
	   love.graphics.line(10*i, 400-10*math.sin(i), 10 * (i+1), 400-10*math.sin((i+1)))
	end
	angle = 3.14/4;
	for j = 0, 100 do
	   love.graphics.line(10*(j*math.cos(angle) - math.sin(j)*math.sin(angle)), 400-10*(math.sin(j)*math.cos(angle) + j * math.sin(angle)), 10*((j+1)*math.cos(angle) - math.sin(j+1)*math.sin(angle)), 400-10*(math.sin(j+1)*math.cos(angle) + (j+1) * math.sin(angle)))
	end
	
end