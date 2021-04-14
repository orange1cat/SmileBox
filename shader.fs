#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

uniform sampler2D ourTexture1;
uniform sampler2D ourTexture2;

void main()
{
	// FragColor = vec4(ourColor, 1.0f);
	// FragColor = texture(ourTexture, TexCoord); // 参数1-纹理采样器，参数2-纹理坐标
	// FragColor = texture(ourTexture, TexCoord) * vec4(ourColor, 1.0); // 把纹理颜色与顶点颜色混合
	// FragColor = mix(texture(ourTexture1, TexCoord), texture(ourTexture2, TexCoord), 0.2); 
	// 纹理混合，如果第三个值是0.0，它会返回第一个输入；如果是1.0，会返回第二个输入值；
	// 0.2会返回80%的第一个输入颜色和20%的第二个输入颜色，即返回两个纹理的混合色
	FragColor = mix(texture(ourTexture1, TexCoord), texture(ourTexture2, vec2(1.0 - TexCoord.x, TexCoord.y)), 0.2); // 使笑脸变向
}