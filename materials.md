---
layout: post
title: Materials
---

The slides for the lessons can be found here:  

{% for slide in site.data.materials.slides %}
{% if slide.published %}
[{{ slide.number }}. {{ slide.name }}]({{site.slides_url}}/{{ slide.url }}){:target="_blank"}
{% else %}
<del>{{ slide.number }}. {{ slide.name }}</del>
{% endif %}
{% endfor %}