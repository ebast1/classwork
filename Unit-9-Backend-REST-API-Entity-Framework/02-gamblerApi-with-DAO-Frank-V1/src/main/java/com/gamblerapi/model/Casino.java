package com.gamblerapi.model;

import java.util.Objects;

public class Casino {
    // Define the data members for the class

    // Casino has
    // 1. Casino Name
    // 2. Casino Location
    // 3. Casino Owner
    // 4. Casino Size

    private String casinoName;
    private String location;
    private String owner;
    private int size;

    public String getCasinoName() { return casinoName; }
    public void setCasinoName(String casinoName) { this.casinoName = casinoName; }
    public String getLocation() { return location; }
    public void setLocation(String location) { this.location = location; }
    public String getOwner() { return owner; }
    public void setOwner(String owner) { this.owner = owner; }
    public int getSize() { return size; }
    public void setSize(int size) { this.size = size; }

    public Casino(String casinoName, String location, String owner, int size) {
        this.casinoName = casinoName;
        this.location = location;
        this.owner = owner;
        this.size = size;
    }

    public Casino() {}

    @Override
    public String toString() {
        return "Casino{" +
                "casinoName='" + casinoName + '\'' +
                ", location='" + location + '\'' +
                ", owner='" + owner + '\'' +
                ", size=" + size +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;
        Casino casino = (Casino) o;
        return size == casino.size && Objects.equals(casinoName, casino.casinoName) && Objects.equals(location, casino.location) && Objects.equals(owner, casino.owner);
    }

    @Override
    public int hashCode() {
        return Objects.hash(casinoName, location, owner, size);
    }
}
