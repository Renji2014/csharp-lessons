---
layout: default
---

<div class="home">

  <h1 class="page-heading">Exercises</h1>
  
  <p>
    <b>The solutions of the exercises can be found on <a href="https://github.com/{{github_username}}{{base_url}}/tree/gh-pages/solutions">GitHub</a></b><br>
    All exercises have assigned a letter corresponding the type of excercise.
  </p>
  <ul>
    <li>A - Geometric Shapes, Points various calculations.</li>
    <li>B - Library, medium (e.g. books or videos) and the connections between them.</li>
    <li>X - For all debugging exercises.</li>
  </ul>

  <ul class="post-list">
    {% assign exercises = site.exercises | sort: 'number' %}

    {% for post in exercises %}
      {% if post.number and post.published != false %}
        {% include index-post.html post=post %}
      {% endif %}
    {% endfor %}

    {% if site.show_drafts %}
      <h2>-- Drafts --</h2>
      {% for post in exercises %}
        {% unless post.number and post.published != false %}
          {% include index-post.html post=post %}
        {% endunless %}
      {% endfor %}
    {% endif %}
  </ul>

  <p class="rss-subscribe">subscribe <a href="{{ "/feed.xml" | prepend: site.baseurl }}">via RSS</a></p>

</div>
