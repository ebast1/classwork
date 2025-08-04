package com.gamblerapi.dao.CasinoDAO;

import com.gamblerapi.model.Casino;

import java.util.ArrayList;
import java.util.List;

public class CasinoMemoryDao {

    // Define the data source

    List<Casino> theCasinos;

    public CasinoMemoryDao() {
        this.theCasinos = new ArrayList<Casino>();
    }

    public List<Casino> getTheCasinos() {
        return theCasinos;
    }
}
