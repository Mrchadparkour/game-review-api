# queries

<ul>
    <li>Get all games with platform data: ``` select g.*, group_concat(DISTINCT c.name ORDER BY c.name DESC SEPERATOR ', ') from game g inner join console_game cg on g.id = cd.game_id inner join consoles c on cg.console_id = c.id group by g.id, g.name; ```</li>
</ul>