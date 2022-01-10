# NBP_GymSpace
Cassandra project

Keyspace and table creation instructions:

CREATE KEYSPACE gymspace WITH REPLICATION = { 'class' : 'NetworkTopologyStrategy', 'datacenter1' : 3 };
USE gymspace;
CREATE TABLE member(memberid text, firstname text, lastname text, PRIMARY KEY (memberid));
CREATE TABLE membership(memberid text, lastsfrom text, lastsuntil text, gym text, PRIMARY KEY (memberid));
CREATE TABLE gym(name text, phone text, address text, city text, country text, PRIMARY KEY (name));
CREATE TABLE workout(workoutid text, memberid text, gymname text, date text, starttime text, endtime text, exercise text, PRIMARY KEY (workoutid));
