---
layout: post
title: Solutions
---

<div class="home">

  <h1 class="page-heading">Solutions</h1>
  
  <p>
    All exercises have assigned a letter corresponding the type of exercise.
  </p>
  <ul>
    <li>A - Geometric Shapes, Points various calculations.</li>
    <li>B - Library, medium (e.g. books or videos) and the connections between them.</li>
    <li>X - For all debugging exercises.</li>
  </ul>

  <ul class="post-list">
    {% assign solutions = site.solutions | sort: 'number' %}

    {% for post in solutions %}
      {% if post.number and post.published != false %}
        {% include index-post.html post=post %}
      {% endif %}
    {% endfor %}

    {% if site.show_drafts %}
      <h2>-- Drafts --</h2>
      {% for post in solutions %}
        {% unless post.number and post.published != false %}
          {% include index-post.html post=post %}
        {% endunless %}
      {% endfor %}
    {% endif %}
  </ul>

  <p class="rss-subscribe">subscribe <a href="{{ "/feed.xml" | prepend: site.baseurl }}">via RSS</a></p>

</div>
