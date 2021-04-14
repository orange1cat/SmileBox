#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aColor;
layout (location = 2) in vec2 aTexCoord;

out vec3 ourColor;
out vec2 TexCoord;

uniform float xOffset; // x_Offset
uniform mat4 transform; // 接收变换矩阵

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
	// gl_Position = vec4(aPos, 1.0);
	// gl_Position = vec4(aPos.x + xOffset, -aPos.y, aPos.z, 1.0);
	// gl_Position = transform * vec4(aPos, 1.0f);
	gl_Position = projection * view * model * vec4(aPos, 1.0);
	ourColor = aColor;
	TexCoord = aTexCoord;
	// TexCoord = vec2(aTexCoord.x, 1.0 - aTexCoord.y);
}