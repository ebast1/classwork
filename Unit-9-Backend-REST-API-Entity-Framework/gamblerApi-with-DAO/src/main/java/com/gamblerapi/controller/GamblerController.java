package com.gamblerapi.controller;

import com.gamblerapi.dao.GamblerDAO.GamblerMemoryDao;
import com.gamblerapi.model.Gambler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class GamblerController {

    private GamblerMemoryDao gamblerDao;

    public GamblerController() {
        this.gamblerDao = new GamblerMemoryDao();
    }

    @GetMapping("/")
    public String methodNameIsNotImportantButMustBeUnique() {
        return "Welcome to Gambler API";
    }

    @GetMapping("/gamblers")
        public List<Gambler> getAllGamblers() {
            return gamblerDao.getGamblers();
        }

}
