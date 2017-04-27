---
layout: page
title: About
permalink: /about/
---

This site hosts the exercises for the fsr C# lessons.
Sources can be found on [GitHub](https://github.com/{{site.github_username}}{{site.base_url}}/tree/gh-pages)


Modules and concepts this course wants to teach:

{% for target in site.data.overview.targets %}
- {{ target }}{% endfor %}
