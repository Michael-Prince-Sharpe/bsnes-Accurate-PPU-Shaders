#version 150

uniform sampler2D source[];
uniform vec4 sourceSize[];
uniform vec4 targetSize;

in Vertex {
   vec2 texCoord;
};

out vec4 fragColor;

void main() {
   vec2 one_px = texCoord.xy * sourceSize[0].zw;
   fragColor = texture(source[0], texCoord - vec2(float(mod(one_px, 2.00001))));
}